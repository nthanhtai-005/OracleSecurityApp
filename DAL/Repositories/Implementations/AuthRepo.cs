using System.Data;
using DAL.Providers;
using DAL.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace DAL.Repositories.Implementations
{
    public class AuthRepo : IAuthRepo
    {
        private readonly OracleConnectionManager _connectionManager;

        public AuthRepo()
        {
            _connectionManager = new OracleConnectionManager();
        }

        public DataTable GetAuthInfo(string username)
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                // Sử dụng Parameter (:username) thay vì cộng chuỗi trực tiếp
                string sql = "SELECT PASSWORD_HASH, SALT FROM ADMIN_BM.APP_USERS WHERE USERNAME = UPPER(:username)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    // Truyền giá trị an toàn vào parameter
                    cmd.Parameters.Add(new OracleParameter("username", username));

                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetSessionPrivileges()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                string sqlPrivs = "SELECT PRIVILEGE FROM SESSION_PRIVS";
                using (OracleCommand cmd = new OracleCommand(sqlPrivs, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void UpdateUserPassword(string username, string newHash, string newSalt)
        {
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                string sqlUpdate = "UPDATE ADMIN_BM.APP_USERS SET PASSWORD_HASH = :newHash, SALT = :newSalt WHERE USERNAME = UPPER(:username)";

                using (OracleCommand cmd = new OracleCommand(sqlUpdate, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("newHash", newHash));
                    cmd.Parameters.Add(new OracleParameter("newSalt", newSalt));
                    cmd.Parameters.Add(new OracleParameter("username", username));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetAppUserInfo(string username)
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                // Lấy thông tin từ bảng ứng dụng, dùng Parameter chống SQL Injection
                string sql = "SELECT FULLNAME, EMAIL, CREATED_DATE FROM ADMIN_BM.APP_USERS WHERE USERNAME = UPPER(:username)";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("username", username));
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetOracleAccountInfo()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                // USER_USERS tự động cô lập thông tin của tài khoản đang đăng nhập
                string sql = "SELECT ACCOUNT_STATUS, LOCK_DATE, DEFAULT_TABLESPACE, TEMPORARY_TABLESPACE FROM USER_USERS";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetUserRoles()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT GRANTED_ROLE AS ROLE_NAME, 'YES' AS IS_DIRECT, ADMIN_OPTION 
                    FROM USER_ROLE_PRIVS
                    UNION ALL
                    SELECT ROLE AS ROLE_NAME, 'NO' AS IS_DIRECT, 'NO' AS ADMIN_OPTION 
                    FROM SESSION_ROLES 
                    WHERE ROLE NOT IN (SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS)";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetUserSystemPrivileges()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT PRIVILEGE, 'Trực tiếp' AS GRANT_METHOD, ADMIN_OPTION 
                    FROM USER_SYS_PRIVS
                    UNION ALL
                    SELECT PRIVILEGE, 'Qua role: ' || ROLE AS GRANT_METHOD, ADMIN_OPTION 
                    FROM ROLE_SYS_PRIVS 
                    WHERE ROLE IN (SELECT ROLE FROM SESSION_ROLES)";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetUserObjectPrivileges()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT TABLE_NAME, PRIVILEGE, GRANTOR, GRANTABLE 
                    FROM USER_TAB_PRIVS
                    UNION ALL
                    SELECT TABLE_NAME, PRIVILEGE, 'Qua role: ' || ROLE AS GRANTOR, GRANTABLE 
                    FROM ROLE_TAB_PRIVS 
                    WHERE ROLE IN (SELECT ROLE FROM SESSION_ROLES)";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }
        public DataTable GetUserQuotas()
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT TABLESPACE_NAME, BYTES AS USED_BYTES, 
                           CASE WHEN MAX_BYTES = -1 THEN 'UNLIMITED' ELSE TO_CHAR(MAX_BYTES) END AS LIMIT_BYTES 
                    FROM USER_TS_QUOTAS";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }
    }
}