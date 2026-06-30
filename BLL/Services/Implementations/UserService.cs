using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Interface;
using DAL.Repositories.Implementations;
using MODELS;
using DAL.Repositories.Interface;
using BLL.Security;



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
            string salt = HashHelper.GenerateSalt();
            string passwordHash =
                HashHelper.HashPassword(request.Password, salt);

            request.Salt = salt;
            request.PasswordHash = passwordHash;

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

        public List<string> GetTablespaces()
        {
            return _repo.GetTablespaces();
        }

        public List<string> GetTemporaryTablespaces()
        {
            return _repo.GetTemporaryTablespaces();
        }

        public void UpdateUserAccount(
                string username,
                string password,
                string defaultTablespace,
                string temporaryTablespace,
                int quotaMB,
                string fullname,
                string email)
        {
            string passwordHash = "";
            string salt = "";

            if (!string.IsNullOrWhiteSpace(password))
            {
                salt = HashHelper.GenerateSalt();
                passwordHash = HashHelper.HashPassword(password, salt);
            }

            _repo.UpdateUserAccount(
                username,
                password,
                passwordHash,
                salt,
                defaultTablespace,
                temporaryTablespace,
                quotaMB,
                fullname,
                email);
        }

    }
}
