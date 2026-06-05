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
        private readonly string _connectionString = "User Id=sys; Password=nthanhtai; Data Source=localhost:1521/FREEPDB1; DBA Privilege=SYSDBA;";

        public OracleConnection GetConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}
