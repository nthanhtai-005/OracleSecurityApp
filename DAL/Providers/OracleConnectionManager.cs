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
    }
}
