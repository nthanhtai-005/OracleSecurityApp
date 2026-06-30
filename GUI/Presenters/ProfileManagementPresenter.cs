using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Interface;
using BLL.Services.Implementations;
using DAL.Providers;
using DAL.Repositories.Implementations;
using MODELS;

namespace GUI.Presenters
{
    public class ProfileManagementPresenter
    {
        private readonly IUserService _service;

        public ProfileManagementPresenter()
        {
            var repo = new UserRepository(
                OracleConnectionManager.CurrentConnectionString);

            _service = new UserService(repo);
        }

        public List<OracleProfileSummary> GetProfileSummaries()
        {
            return _service.GetProfileSummaries();
        }

        public void DeleteProfile(string profileName)
        {
            _service.DeleteProfile(profileName);
        }
        public List<OracleProfile> GetProfilesDetail()
        {
            return _service.GetProfilesDetail();
        }
    }
}
