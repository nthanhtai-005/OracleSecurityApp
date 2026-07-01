using BLL.Security;
using BLL.Services.Interfaces;
using DAL.Providers;
using DAL.Repositories.Interfaces;
using DTO;
using System;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BLL.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepo _authRepo;

        public AuthService(IAuthRepo authRepo)
        {
            _authRepo = authRepo;
        }

        public bool LoginAndLoadSession(string username, string rawPassword)
        {
            try
            {
                DataTable dtAuth = _authRepo.GetAuthInfo(username);

                if (dtAuth.Rows.Count == 0)
                {
                    return false;
                }

                string storedHash = dtAuth.Rows[0]["PASSWORD_HASH"].ToString();
                string storedSalt = dtAuth.Rows[0]["SALT"].ToString();

                // Băm mật khẩu nhập vào cùng với Salt và so sánh
                string calculatedHash = HashHelper.HashPassword(rawPassword, storedSalt);

                if (calculatedHash != storedHash)
                {
                    return false;
                }

                string userConnString = OracleConnectionManager.BuildDynamicConnectionString(username, rawPassword);

                // Kiểm tra kết nối vào Oracle bằng tài khoản của User
                using (var conn = new Oracle.ManagedDataAccess.Client.OracleConnection(userConnString))
                {
                    conn.Open();
                }

                // Thiết lập Session sau khi xác thực thành công
                SessionContext.ClearSession();
                OracleConnectionManager.CurrentConnectionString = userConnString;
                SessionContext.CurrentUsername = username;

                DataTable dtPrivs = _authRepo.GetSessionPrivileges();
                foreach (DataRow row in dtPrivs.Rows)
                {
                    SessionContext.CurrentPrivileges.Add(row["PRIVILEGE"].ToString().ToUpper());
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đăng nhập Oracle: " + ex.Message);
                return false;
            }
        }
        public UserDashboardModel GetUserDashboardInfo(string username)
        {
            var model = new UserDashboardModel { Username = username };

            // 1. Map dữ liệu từ APP_USERS
            DataTable dtApp = _authRepo.GetAppUserInfo(username);
            if (dtApp.Rows.Count > 0)
            {
                DataRow row = dtApp.Rows[0];
                model.FullName = row["FULLNAME"]?.ToString() ?? "N/A";
                model.Email = row["EMAIL"]?.ToString() ?? "N/A";
                model.CreatedDate = row["CREATED_DATE"] != DBNull.Value
                    ? Convert.ToDateTime(row["CREATED_DATE"]).ToString("dd/MM/yyyy")
                    : "N/A";
                model.Profile = row["PROFILE"].ToString() ?? "";
            }

            // 2. Map dữ liệu từ Oracle Dictionary (USER_USERS)
            DataTable dtOra = _authRepo.GetOracleAccountInfo();
            if (dtOra.Rows.Count > 0)
            {
                DataRow row = dtOra.Rows[0];
                model.AccountStatus = row["ACCOUNT_STATUS"]?.ToString() ?? "N/A";
                model.LockDate = row["LOCK_DATE"] != DBNull.Value
                    ? Convert.ToDateTime(row["LOCK_DATE"]).ToString("dd/MM/yyyy")
                    : "Không bị khóa";
                model.DefaultTablespace = row["DEFAULT_TABLESPACE"]?.ToString() ?? "N/A";
                model.TemporaryTablespace = row["TEMPORARY_TABLESPACE"]?.ToString() ?? "N/A";
            }

            return model;
        }

        public DataTable GetUserRoles() => _authRepo.GetUserRoles();
        public DataTable GetUserSystemPrivileges() => _authRepo.GetUserSystemPrivileges();
        public DataTable GetUserObjectPrivileges() => _authRepo.GetUserObjectPrivileges();
        public DataTable GetUserQuotas() => _authRepo.GetUserQuotas();
        public bool HasGrantablePrivileges()
        {
            return _authRepo.CheckUserHasGrantablePrivileges();
        }
    }
}