using Oracle.ManagedDataAccess.Client;
using System.Configuration; 

namespace DAL.Providers
{
    public class OracleConnectionManager
    {
        // Lưu chuỗi kết nối hiện tại của user đăng nhập
        private static string _currentConnectionString;

        public static string CurrentConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_currentConnectionString))
                {
                    _currentConnectionString = ConfigurationManager.ConnectionStrings["OracleDefaultConn"].ConnectionString;
                }
                return _currentConnectionString;
            }
            set
            {
                _currentConnectionString = value;
            }
        }

        public OracleConnection GetConnection()
        {
            return new OracleConnection(CurrentConnectionString);
        }

        // Đọc Data Source từ App.config và đổi User/Pass để tạo chuỗi kết nối động
        public static string BuildDynamicConnectionString(string username, string password)
        {
            string baseString = ConfigurationManager.ConnectionStrings["OracleDefaultConn"].ConnectionString;

            OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder(baseString);
            builder.UserID = username;
            builder.Password = password;

            return builder.ConnectionString;
        }
    }
}