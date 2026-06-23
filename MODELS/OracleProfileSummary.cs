using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class OracleProfileSummary
    {
        public string ProfileName { get; set; } = "";

        public string FailedLoginAttempts { get; set; } = "";

        public string PasswordLifeTime { get; set; } = "";

        public string PasswordLockTime { get; set; } = "";

        public string PasswordGraceTime { get; set; } = "";

        public string SessionsPerUser { get; set; } = "";

        public string ConnectTime { get; set; } = "";

        public string IdleTime { get; set; } = "";

        public int UserCount { get; set; }
    }
}
