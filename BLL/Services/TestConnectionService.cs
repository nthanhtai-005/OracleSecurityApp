using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace BLL.Services
{
    public class TestConnectionService
    {
        private readonly DbExecutor _dbExecutor;

        public TestConnectionService()
        {
            _dbExecutor = new DbExecutor();
        }

        public void TestAndCreateUser(string username, string password)
        {
            // 1. Kiểm tra dữ liệu (Validation)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Username và Password không được để trống!");
            }

            string sqlCreateUser = $"CREATE USER {username} IDENTIFIED BY {password}";
            string sqlGrantSession = $"GRANT CREATE SESSION TO {username}";
            // Đẩy câu lệnh SQL vào DbExecutor để thực thi
            _dbExecutor.ExecuteNonQuery(sqlCreateUser);
            _dbExecutor.ExecuteNonQuery(sqlGrantSession);
        }
    }
}
