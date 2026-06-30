using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class OracleUser
    {
        public string Username { get; set; } = "";
        public string AccountStatus { get; set; } = "";
        public string Profile { get; set; } = "";
        public string DefaultTablespace { get; set; } = "";
        public string TemporaryTablespace { get; set; } = "";
        public string Fullname { get; set; } = "";
        public string Email { get; set; } = "";
        public string Quota { get; set; } = "";
        public DateTime Created { get; set; }
    }
}
