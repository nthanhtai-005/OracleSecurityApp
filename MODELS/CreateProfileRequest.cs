using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class CreateProfileRequest
    {
        public string ProfileName { get; set; } = "";

        public string FailedLoginAttempts { get; set; } = "DEFAULT";
        public string PasswordLifeTime { get; set; } = "DEFAULT";
        public string PasswordLockTime { get; set; } = "DEFAULT";
        public string PasswordGraceTime { get; set; } = "DEFAULT";
        public string SessionsPerUser { get; set; } = "DEFAULT";
        public string ConnectTime { get; set; } = "DEFAULT";
        public string IdleTime { get; set; } = "DEFAULT";
    }
}
