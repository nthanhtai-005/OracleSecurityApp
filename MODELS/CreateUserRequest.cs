using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class CreateUserRequest
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Profile { get; set; } = "";
        public string DefaultTablespace { get; set; } = "";
        public string TemporaryTablespace { get; set; } = "";
        public int QuotaMB { get; set; }

        public string Fullname { get; set; } = "";
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Salt { get; set; } = "";
    }
}
