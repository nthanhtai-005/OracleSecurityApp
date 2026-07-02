using System.Data;

namespace BLL.Services.Interfaces
{
    public interface IDataDictionaryService
    {
        DataTable GetPrivilegeTable();
        DataTable GetRoleTable();
        DataTable GetProfileTable();
        DataTable GetUserTable();
    }
}