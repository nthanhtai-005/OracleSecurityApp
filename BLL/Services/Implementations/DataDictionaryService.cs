using System.Data;
using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Implementations;

namespace BLL.Services.Implementations
{
    public class DataDictionaryService : IDataDictionaryService
    {
        private readonly IDataDictionaryRepo _repo;

        public DataDictionaryService()
        {
            _repo = new DataDictionaryRepo();
        }

        public DataTable GetPrivilegeTable() => _repo.GetPrivilegeManagement();
        public DataTable GetRoleTable() => _repo.GetRoleManagement();
        public DataTable GetProfileTable() => _repo.GetProfileManagement();
        public DataTable GetUserTable() => _repo.GetUserManagement();
    }
}