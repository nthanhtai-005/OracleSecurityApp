using DAL.Providers;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DbExecutor
    {
        private readonly OracleConnectionManager _connectionManager;

        public DbExecutor()
        {
            _connectionManager = new OracleConnectionManager();
        }

        public void ExecuteNonQuery(string sqlCommand)
        {
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sqlCommand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
