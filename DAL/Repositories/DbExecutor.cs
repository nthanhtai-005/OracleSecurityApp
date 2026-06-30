using DAL.Providers;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        // Hàm TRẢ VỀ DỮ LIỆU DẠNG BẢNG (Dùng cho SELECT lấy danh sách, đổ lên DataGridView)
        public DataTable ExecuteQuery(string sqlCommand)
        {
            DataTable dataTable = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sqlCommand, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public DataTable ExecuteQuery(string sqlCommand, OracleParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sqlCommand, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        // 3. Hàm TRẢ VỀ 1 GIÁ TRỊ DUY NHẤT (Dùng cho SELECT lấy 1 ô dữ liệu, ví dụ lấy mã Hash, hoặc COUNT)
        public object ExecuteScalar(string sqlCommand)
        {
            using (OracleConnection conn = _connectionManager.GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sqlCommand, conn))
                {
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
