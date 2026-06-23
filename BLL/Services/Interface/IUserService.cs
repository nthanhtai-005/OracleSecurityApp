using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace BLL.Services.Interface
{
    public interface IUserService
    {
        List<OracleUser> GetAllUsers();
        List<string> GetProfiles();
        List<OracleProfileSummary> GetProfileSummaries(string keyword = "");
        void CreateUser(CreateUserRequest request);
        void DeleteUser(string username);
        void LockUser(string username);
        void UnLockUser(string username);
        void ChangePassword(string username,string password);
        void AssignProfile(string username,string profileName);
        List<OracleProfile>GetProfilesDetail();
        void CreateProfile(CreateProfileRequest request);
        void UpdateProfile(CreateProfileRequest request);
        void DeleteProfile(string username);

    }
}
