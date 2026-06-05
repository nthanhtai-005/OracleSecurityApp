using BLL.Security;  // Gọi SessionContext
using DAL.Providers; // Gọi ConnectionManager
using DAL.Repositories;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        private readonly DbExecutor _dbExecutor;

        public AuthService()
        {
            _dbExecutor = new DbExecutor();
        }
        // ĐÂY LÀ HÀM ĐĂNG NHẬP SAU KHI MN CODE XONG MÌNH SẼ SỬA LẠI HÀM NÀY THEO CƠ CHẾ HASH PASSWORD
        public bool LoginAndLoadSession(string username, string rawPassword)
        {
            // 1. Tạo chuỗi kết nối động dựa trên user/pass người dùng nhập
            // Lưu ý: Tùy user có quyền SYSDBA hay không mà chuỗi này có thể cần sửa lại chút xíu
            string testConnString = $"User Id={username}; Password={rawPassword}; Data Source=localhost:1521/FREEPDB1;";
            if (username.Trim().ToUpper() == "SYS")
            {
                testConnString += " DBA Privilege=SYSDBA;";
            }

            try
            {
                // 2. Thử mở kết nối. Nếu sai pass, Oracle sẽ văng Exception ngay tại đây!
                using (var conn = new Oracle.ManagedDataAccess.Client.OracleConnection(testConnString))
                {
                    conn.Open();
                }

                // 3. NẾU THÀNH CÔNG: Chốt chuỗi kết nối này cho toàn bộ app sử dụng về sau
                OracleConnectionManager.CurrentConnectionString = testConnString;

                // 4. Nạp thông tin vào RAM
                SessionContext.ClearSession();
                SessionContext.CurrentUsername = username;

                // 5. Lấy danh sách quyền từ Oracle
                string sqlPrivs = "SELECT PRIVILEGE FROM SESSION_PRIVS";
                DataTable dtPrivs = _dbExecutor.ExecuteQuery(sqlPrivs);

                foreach (DataRow row in dtPrivs.Rows)
                {
                    SessionContext.CurrentPrivileges.Add(row["PRIVILEGE"].ToString().ToUpper());
                }

                return true; // Đăng nhập thành công
            }
            catch
            {
                // Nếu văng lỗi (sai pass, user bị lock...) thì trả về false
                return false;
            }
        }

        /*
         
        public bool LoginAndLoadSession(string username, string rawPassword)
        {
            // 1. Lấy chuỗi Hash và Salt của user này từ Database (Giả sử bạn có bảng APP_USERS)
            // Cú pháp phụ thuộc vào bảng của Nguyễn Thành Tài tạo
            string sqlGetAuth = $"SELECT Password_Hash, Salt FROM APP_USERS WHERE Username = '{username.ToUpper()}'";
            DataTable dtAuth = _dbExecutor.ExecuteQuery(sqlGetAuth);

            if (dtAuth.Rows.Count == 0) return false; // Không tìm thấy user

            string storedHash = dtAuth.Rows[0]["Password_Hash"].ToString();
            string storedSalt = dtAuth.Rows[0]["Salt"].ToString();

            // 2. Lấy pass người dùng nhập trộn với Salt từ DB, băm ra xem có khớp không
            string calculatedHash = HashHelper.HashPassword(rawPassword, storedSalt);

            if (calculatedHash == storedHash)
            {
                // 3. Đăng nhập thành công -> Nạp quyền vào SessionContext
                SessionContext.ClearSession();
                SessionContext.CurrentUsername = username;

                // Lấy toàn bộ quyền hệ thống
                string sqlPrivs = "SELECT PRIVILEGE FROM SESSION_PRIVS";
                DataTable dtPrivs = _dbExecutor.ExecuteQuery(sqlPrivs);

                foreach (DataRow row in dtPrivs.Rows)
                {
                    SessionContext.CurrentPrivileges.Add(row["PRIVILEGE"].ToString().ToUpper());
                }

                return true; // Báo cho giao diện biết đã thành công
            }

            return false; // Sai mật khẩu
        }

        */

        public void SeedDataMatKhauChoNhom()
        {
            // 1. Danh sách các tài khoản và mật khẩu gốc cần đồng bộ
            var danhSachUser = new System.Collections.Generic.Dictionary<string, string>
            {
                { "ADMIN_BM", "Oracle_1234" },
                { "NTHANHTAI", "Tai_1234" },
                { "PVNHATKHA", "Kha_1234" },
                { "NTPTHANH", "Thanh_1234" }
            };

            // 2. Chạy vòng lặp để cập nhật từng người
            foreach (var item in danhSachUser)
            {
                string username = item.Key;
                string rawPass = item.Value;

                // Sinh Salt và Hash chuẩn xác từ code C# của bạn
                string newSalt = HashHelper.GenerateSalt();
                string newHash = HashHelper.HashPassword(rawPass, newSalt);

                // Chạy lệnh UPDATE đè lên dữ liệu cũ trong bảng APP_USERS
                string sqlUpdate = $"UPDATE APP_USERS SET Password_Hash = '{newHash}', Salt = '{newSalt}' WHERE Username = '{username}'";

                // Lưu ý: Đảm bảo _dbExecutor đang chạy bằng chuỗi kết nối của ADMIN_BM nhé
                _dbExecutor.ExecuteNonQuery(sqlUpdate);
            }
        }
    }
}
