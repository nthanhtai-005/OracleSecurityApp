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
    }
}