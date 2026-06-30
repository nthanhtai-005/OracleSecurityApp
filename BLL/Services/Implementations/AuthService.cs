using System;
using System.Data;
using BLL.Security;
using BLL.Services.Interfaces;
using DAL.Providers;
using DAL.Repositories.Interfaces;

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
    }
}