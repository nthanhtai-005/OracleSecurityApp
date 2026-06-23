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
                    USERNAME,
                    ACCOUNT_STATUS,
                    PROFILE,
                    DEFAULT_TABLESPACE,
                    CREATED
                FROM DBA_USERS
                ORDER BY USERNAME";

            using (OracleConnection conn =
                   new OracleConnection(_connectionString))
            {
                conn.Open();

                using (OracleCommand cmd =
                       new OracleCommand(sql, conn))
                {
                    using (OracleDataReader reader =
                           cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new OracleUser
                            {
                                Username =
                                    reader["USERNAME"].ToString(),

                                AccountStatus =
                                    reader["ACCOUNT_STATUS"].ToString(),

                                Profile =
                                    reader["PROFILE"].ToString(),

                                DefaultTablespace =
                                    reader["DEFAULT_TABLESPACE"].ToString(),

                                Created =
                                    Convert.ToDateTime(
                                        reader["CREATED"])
                            });
                        }
                    }
                }
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

        public void CreateUser(CreateUserRequest request)
        {
            string sql = $@"
        CREATE USER {request.Username}
        IDENTIFIED BY ""{request.Password}""
        DEFAULT TABLESPACE {request.DefaultTablespace}
        PROFILE {request.Profile}";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            string grantSql =
                $"GRANT CREATE SESSION TO {request.Username}";

            using OracleCommand grantCmd =
                new OracleCommand(grantSql, conn);

            grantCmd.ExecuteNonQuery();
        }
        public void DeleteUser(string username)
        {
            string sql =
                $"DROP USER {username} CASCADE";

            using OracleConnection conn =
                new OracleConnection(_connectionString);

            conn.Open();

            using OracleCommand cmd =
                new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();
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
