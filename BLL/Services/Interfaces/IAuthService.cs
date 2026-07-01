using DTO;
using System.Data;

namespace BLL.Services.Interfaces
{
    public interface IAuthService
    {
        bool LoginAndLoadSession(string username, string rawPassword);
        UserDashboardModel GetUserDashboardInfo(string username);

        DataTable GetUserRoles();
        DataTable GetUserSystemPrivileges();
        DataTable GetUserObjectPrivileges();
        DataTable GetUserQuotas();
        bool HasGrantablePrivileges();
    }
}