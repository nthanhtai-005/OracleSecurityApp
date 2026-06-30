using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Interface;
using Oracle.ManagedDataAccess.Client;
using MODELS;



namespace DAL.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<OracleUser> GetAllUsers()
        {
            List<OracleUser> users = new();

            string sql = @"
        SELECT
            u.USERNAME,
            u.ACCOUNT_STATUS,
            u.PROFILE,
            u.DEFAULT_TABLESPACE,
            u.TEMPORARY_TABLESPACE,
            u.CREATED,
            NVL(a.FULLNAME, '') AS FULLNAME,
            NVL(a.EMAIL, '') AS EMAIL,
            NVL(q.QUOTA, '0 MB') AS QUOTA
        FROM DBA_USERS u
        LEFT JOIN APP_USERS a
            ON u.USERNAME = a.USERNAME
        LEFT JOIN (
            SELECT
                USERNAME,
                MAX(
                    CASE
                        WHEN MAX_BYTES = -1 THEN 'UNLIMITED'
                        ELSE TO_CHAR(ROUND(MAX_BYTES / 1024 / 1024)) || ' MB'
                    END
                ) AS QUOTA
            FROM DBA_TS_QUOTAS
            GROUP BY USERNAME
        ) q
            ON u.USERNAME = q.USERNAME
        ORDER BY u.USERNAME";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            using OracleDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new OracleUser
                {
                    Username = reader["USERNAME"]?.ToString() ?? "",
                    AccountStatus = reader["ACCOUNT_STATUS"]?.ToString() ?? "",
                    Profile = reader["PROFILE"]?.ToString() ?? "",
                    DefaultTablespace = reader["DEFAULT_TABLESPACE"]?.ToString() ?? "",
                    TemporaryTablespace = reader["TEMPORARY_TABLESPACE"]?.ToString() ?? "",
                    Fullname = reader["FULLNAME"]?.ToString() ?? "",
                    Email = reader["EMAIL"]?.ToString() ?? "",
                    Quota = reader["QUOTA"]?.ToString() ?? "",
                    Created = Convert.ToDateTime(reader["CREATED"])
                });
            }

            return users;
        }

        public List<string> GetProfiles()
        {
            List<string> profiles = new();

            string sql =
                @"SELECT DISTINCT PROFILE
          FROM DBA_PROFILES
          ORDER BY PROFILE";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            using OracleDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                profiles.Add(
                    reader["PROFILE"]
                    .ToString() ?? "");
            }

            return profiles;
        }

        public List<string> GetTablespaces()
        {
            List<string> tablespaces = new();

            string sql = @"
        SELECT TABLESPACE_NAME
        FROM DBA_TABLESPACES
        WHERE CONTENTS = 'PERMANENT'
        ORDER BY TABLESPACE_NAME";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            using OracleDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                tablespaces.Add(
                    reader["TABLESPACE_NAME"]?.ToString() ?? "");
            }

            return tablespaces;
        }

        public List<string> GetTemporaryTablespaces()
        {
            List<string> tablespaces = new();

            string sql = @"
        SELECT TABLESPACE_NAME
        FROM DBA_TABLESPACES
        WHERE CONTENTS = 'TEMPORARY'
        ORDER BY TABLESPACE_NAME";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            using OracleDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                tablespaces.Add(
                    reader["TABLESPACE_NAME"]?.ToString() ?? "");
            }

            return tablespaces;
        }

        public void CreateUser(CreateUserRequest request)
        {
            string createUserSql = $@"
        CREATE USER {request.Username}
        IDENTIFIED BY ""{request.Password}""
        DEFAULT TABLESPACE {request.DefaultTablespace}
        TEMPORARY TABLESPACE {request.TemporaryTablespace}
        QUOTA {request.QuotaMB}M ON {request.DefaultTablespace}
        PROFILE {request.Profile}";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleTransaction tran =
                conn.BeginTransaction();

            try
            {
                using OracleCommand createCmd =
                    new OracleCommand(createUserSql, conn);

                createCmd.Transaction = tran;
                createCmd.ExecuteNonQuery();

                string grantSql =
                    $"GRANT CREATE SESSION TO {request.Username}";

                using OracleCommand grantCmd =
                    new OracleCommand(grantSql, conn);

                grantCmd.Transaction = tran;
                grantCmd.ExecuteNonQuery();
                string insertAppUserSql = @"
    INSERT INTO APP_USERS
    (
        USERNAME,
        PASSWORD_HASH,
        SALT,
        FULLNAME,
        EMAIL
    )
    VALUES
    (
        :username,
        :passwordHash,
        :salt,
        :fullname,
        :email
    )";

                using OracleCommand insertCmd =
                    new OracleCommand(insertAppUserSql, conn);

                insertCmd.Transaction = tran;

                insertCmd.Parameters.Add(":username", request.Username.ToUpper());
                insertCmd.Parameters.Add(":passwordHash", request.PasswordHash);
                insertCmd.Parameters.Add(":salt", request.Salt);
                insertCmd.Parameters.Add(":fullname", request.Fullname);
                insertCmd.Parameters.Add(":email", request.Email);

                insertCmd.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        public void DeleteUser(string username)
        {
            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleTransaction tran =
                conn.BeginTransaction();

            try
            {
                string deleteAppUserSql =
                    @"DELETE FROM APP_USERS
              WHERE USERNAME = :username";

                using OracleCommand deleteAppCmd =
                    new OracleCommand(deleteAppUserSql, conn);

                deleteAppCmd.Transaction = tran;
                deleteAppCmd.Parameters.Add(":username", username.ToUpper());
                deleteAppCmd.ExecuteNonQuery();

                string dropUserSql =
                    $"DROP USER {username} CASCADE";

                using OracleCommand dropCmd =
                    new OracleCommand(dropUserSql, conn);

                dropCmd.Transaction = tran;
                dropCmd.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        public void LockUser(string username)
        {
            string sql =
                $"ALTER USER {username} ACCOUNT LOCK";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }

        public void UnLockUser(string username)
        {
            string sql =
                $"ALTER USER {username} ACCOUNT UNLOCK";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }
        public void ChangePassword(string username, string password)
        {
            string sql =
                $@"ALTER USER {username}
           IDENTIFIED BY ""{password}""";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }

        public void UpdateUserAccount(
    string username,
    string password,
    string passwordHash,
    string salt,
    string defaultTablespace,
    string temporaryTablespace,
    int quotaMB,
    string fullname,
    string email)
        {
            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleTransaction tran =
                conn.BeginTransaction();

            try
            {
                if (!string.IsNullOrWhiteSpace(password))
                {
                    string alterPasswordSql =
                        $@"ALTER USER {username}
                   IDENTIFIED BY ""{password}""";

                    using OracleCommand passwordCmd =
                        new OracleCommand(alterPasswordSql, conn);

                    passwordCmd.Transaction = tran;
                    passwordCmd.ExecuteNonQuery();

                    string updatePasswordAppSql = @"
                UPDATE APP_USERS
                SET PASSWORD_HASH = :passwordHash,
                    SALT = :salt
                WHERE USERNAME = :username";

                    using OracleCommand updatePassCmd =
                        new OracleCommand(updatePasswordAppSql, conn);

                    updatePassCmd.Transaction = tran;
                    updatePassCmd.Parameters.Add(":passwordHash", passwordHash);
                    updatePassCmd.Parameters.Add(":salt", salt);
                    updatePassCmd.Parameters.Add(":username", username.ToUpper());

                    updatePassCmd.ExecuteNonQuery();
                }

                string alterUserSql = $@"
            ALTER USER {username}
            DEFAULT TABLESPACE {defaultTablespace}
            TEMPORARY TABLESPACE {temporaryTablespace}
            QUOTA {quotaMB}M ON {defaultTablespace}";

                using OracleCommand alterCmd =
                    new OracleCommand(alterUserSql, conn);

                alterCmd.Transaction = tran;
                alterCmd.ExecuteNonQuery();

                string updateAppUserSql = @"
            UPDATE APP_USERS
            SET FULLNAME = :fullname,
                EMAIL = :email
            WHERE USERNAME = :username";

                using OracleCommand updateAppCmd =
                    new OracleCommand(updateAppUserSql, conn);

                updateAppCmd.Transaction = tran;
                updateAppCmd.Parameters.Add(":fullname", fullname);
                updateAppCmd.Parameters.Add(":email", email);
                updateAppCmd.Parameters.Add(":username", username.ToUpper());

                updateAppCmd.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        public void AssignProfile(string username, string profileName)
        {
            string sql =
                $@"ALTER USER {username}
           PROFILE {profileName}";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }
        public List<OracleProfile>
    GetProfilesDetail()
        {
            List<OracleProfile> profiles = new();

            string sql = @"
        SELECT
            PROFILE,
            RESOURCE_NAME,
            LIMIT
        FROM DBA_PROFILES
        ORDER BY PROFILE";

            using OracleConnection conn =
                new OracleConnection(
                    _connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(
                    sql,
                    conn);

            using OracleDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                profiles.Add(
                    new OracleProfile
                    {
                        ProfileName =
                            reader["PROFILE"]
                            ?.ToString()
                            ?? "",

                        ResourceName =
                            reader["RESOURCE_NAME"]
                            ?.ToString()
                            ?? "",

                        LimitValue =
                            reader["LIMIT"]
                            ?.ToString()
                            ?? ""
                    });
            }

            return profiles;
        }

        public void CreateProfile(CreateProfileRequest request)
        {
            string sql = $@"
        CREATE PROFILE {request.ProfileName}
        LIMIT
        FAILED_LOGIN_ATTEMPTS {request.FailedLoginAttempts}
        PASSWORD_LIFE_TIME {request.PasswordLifeTime}
        PASSWORD_LOCK_TIME {request.PasswordLockTime}
        PASSWORD_GRACE_TIME {request.PasswordGraceTime}
        SESSIONS_PER_USER {request.SessionsPerUser}
        CONNECT_TIME {request.ConnectTime}
        IDLE_TIME {request.IdleTime}";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }
        public void UpdateProfile(CreateProfileRequest request)
        {
            string sql = $@"
        ALTER PROFILE {request.ProfileName}
        LIMIT
        FAILED_LOGIN_ATTEMPTS {request.FailedLoginAttempts}
        PASSWORD_LIFE_TIME {request.PasswordLifeTime}
        PASSWORD_LOCK_TIME {request.PasswordLockTime}
        PASSWORD_GRACE_TIME {request.PasswordGraceTime}
        SESSIONS_PER_USER {request.SessionsPerUser}
        CONNECT_TIME {request.ConnectTime}
        IDLE_TIME {request.IdleTime}";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }
        public void DeleteProfile(string profileName)
        {
            string sql = $"DROP PROFILE {profileName} CASCADE";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }
        public List<OracleProfileSummary> GetProfileSummaries(string keyword = "")
        {
            List<OracleProfileSummary> profiles = new();

            string sql = @"
        SELECT
            p.PROFILE,

            MAX(CASE WHEN p.RESOURCE_NAME = 'FAILED_LOGIN_ATTEMPTS' 
                     THEN p.LIMIT END) AS FAILED_LOGIN_ATTEMPTS,

            MAX(CASE WHEN p.RESOURCE_NAME = 'PASSWORD_LIFE_TIME' 
                     THEN p.LIMIT END) AS PASSWORD_LIFE_TIME,

            MAX(CASE WHEN p.RESOURCE_NAME = 'PASSWORD_LOCK_TIME' 
                     THEN p.LIMIT END) AS PASSWORD_LOCK_TIME,

            MAX(CASE WHEN p.RESOURCE_NAME = 'PASSWORD_GRACE_TIME' 
                     THEN p.LIMIT END) AS PASSWORD_GRACE_TIME,

            MAX(CASE WHEN p.RESOURCE_NAME = 'SESSIONS_PER_USER' 
                     THEN p.LIMIT END) AS SESSIONS_PER_USER,

            MAX(CASE WHEN p.RESOURCE_NAME = 'CONNECT_TIME' 
                     THEN p.LIMIT END) AS CONNECT_TIME,

            MAX(CASE WHEN p.RESOURCE_NAME = 'IDLE_TIME' 
                     THEN p.LIMIT END) AS IDLE_TIME,

           COUNT(u.USERNAME) AS USER_COUNT

        FROM DBA_PROFILES p
        LEFT JOIN DBA_USERS u
            ON p.PROFILE = u.PROFILE

        WHERE (:keyword IS NULL OR UPPER(p.PROFILE) LIKE '%' || UPPER(:keyword) || '%')

        GROUP BY p.PROFILE
        ORDER BY p.PROFILE";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.Parameters.Add(
                new OracleParameter("keyword",
                string.IsNullOrWhiteSpace(keyword) ? DBNull.Value : keyword));

            using OracleDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                profiles.Add(new OracleProfileSummary
                {
                    ProfileName = reader["PROFILE"]?.ToString() ?? "",
                    FailedLoginAttempts = reader["FAILED_LOGIN_ATTEMPTS"]?.ToString() ?? "",
                    PasswordLifeTime = reader["PASSWORD_LIFE_TIME"]?.ToString() ?? "",
                    PasswordLockTime = reader["PASSWORD_LOCK_TIME"]?.ToString() ?? "",
                    PasswordGraceTime = reader["PASSWORD_GRACE_TIME"]?.ToString() ?? "",
                    SessionsPerUser = reader["SESSIONS_PER_USER"]?.ToString() ?? "",
                    ConnectTime = reader["CONNECT_TIME"]?.ToString() ?? "",
                    IdleTime = reader["IDLE_TIME"]?.ToString() ?? "",
                    UserCount =Convert.ToInt32(reader["USER_COUNT"])
                });
            }

            return profiles;
        }
    }
}
