using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Interface;
using DAL.Repositories.Implementations;
using MODELS;
using DAL.Repositories.Interface;


namespace BLL.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(
            IUserRepository repo)
        {
            _repo = repo;
        }

        public List<OracleUser> GetAllUsers()
        {
            return _repo.GetAllUsers();
        }

        public List<string> GetProfiles()
        {
            return _repo.GetProfiles();
        }
        public List<OracleProfileSummary> GetProfileSummaries(string keyword = "")
        {
            return _repo.GetProfileSummaries(keyword);
        }
        public void CreateUser(CreateUserRequest request)
        {
            _repo.CreateUser(request);
        }
        public void DeleteUser(string username)
        {
            _repo.DeleteUser(username);
        }
        public void LockUser(string username)
        {
            _repo.LockUser(username);
        }
        public void UnLockUser(string username)
        {
            _repo.UnLockUser(username);
        }
        public void ChangePassword(string username,string password)
        {
            _repo.ChangePassword(username,password);
        }
        public void AssignProfile(string username,string profileName)
        {
            _repo.AssignProfile(
                username,
                profileName);
        }
        public List<OracleProfile>GetProfilesDetail()
        {
            return _repo.GetProfilesDetail();
        }
        public void CreateProfile(CreateProfileRequest request)
        {
            _repo.CreateProfile(request);
        }
        public void UpdateProfile(CreateProfileRequest request)
        {
            _repo.UpdateProfile(request);
        }
        public void DeleteProfile(string username)
        {
            _repo.DeleteProfile(username);
        }
    }
}
