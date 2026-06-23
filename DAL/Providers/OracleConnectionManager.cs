using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL.Providers
{
    public class OracleConnectionManager
    {
        // Chuỗi kết nối
        public static string CurrentConnectionString { get; set; } = "Data Source=localhost:1521/DB_BAOMAT; User Id=ADMIN_BM; Password=Oracle_1234;";

        public OracleConnection GetConnection()
        {
            return new OracleConnection(CurrentConnectionString);
        }

        // Biến static để lưu chuỗi kết nối dùng chung cho toàn phiên làm việc để test
        // Lưu ý: mọi người đổi chuổi kết nối từ phần datasourcce thôi 
        /*   public static string CurrentConnectionString { get; set; } = "Data Source=localhost:1521/FREEPDB1;";

           public OracleConnection GetConnection()
           {
               return new OracleConnection(CurrentConnectionString);
           }
        */
    }
}
