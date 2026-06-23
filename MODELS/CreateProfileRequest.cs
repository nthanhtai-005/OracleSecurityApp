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

        public int FailedLoginAttempts { get; set; }

        public int PasswordLifeTime { get; set; }

        public int PasswordLockTime { get; set; }

        public int PasswordGraceTime { get; set; }

        public int SessionsPerUser { get; set; }

        public int ConnectTime { get; set; }

        public int IdleTime { get; set; }
    }
}
