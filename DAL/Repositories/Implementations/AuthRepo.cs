using System.Data;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.Implementations
{
    public class AuthRepo : IAuthRepo
    {
        private readonly DbExecutor _dbExecutor;

        public AuthRepo()
        {
            _dbExecutor = new DbExecutor();
        }

        public DataTable GetAuthInfo(string username)
        {
            // Lấy Hash và Salt của User
            string sql = $"SELECT PASSWORD_HASH, SALT FROM ADMIN_BM.APP_USERS WHERE USERNAME = '{username.ToUpper()}'";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public DataTable GetSessionPrivileges()
        {
            // Lấy danh sách quyền hệ thống của người đang đăng nhập
            string sqlPrivs = "SELECT PRIVILEGE FROM SESSION_PRIVS";
            return _dbExecutor.ExecuteQuery(sqlPrivs);
        }

        public void UpdateUserPassword(string username, string newHash, string newSalt)
        {
            string sqlUpdate = $"UPDATE ADMIN_BM.APP_USERS SET PASSWORD_HASH = '{newHash}', SALT = '{newSalt}' WHERE USERNAME = '{username.ToUpper()}'";
            _dbExecutor.ExecuteNonQuery(sqlUpdate);
        }
    }
}