using System.Data;

namespace DAL.Repositories.Interfaces
{
    public interface IDataDictionaryRepo
    {
        DataTable GetPrivilegeManagement();
        DataTable GetRoleManagement();
        DataTable GetProfileManagement();
        DataTable GetUserManagement();
    }
}