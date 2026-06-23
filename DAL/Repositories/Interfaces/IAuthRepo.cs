using System.Data;

namespace DAL.Repositories.Interfaces
{
    public interface IAuthRepo
    {
        DataTable GetAuthInfo(string username);
        DataTable GetSessionPrivileges();
        void UpdateUserPassword(string username, string newHash, string newSalt);
    }
}