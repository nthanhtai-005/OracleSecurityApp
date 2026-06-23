using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class OracleUser
    {
        public string Username { get; set; } = string.Empty;
        public string AccountStatus { get; set; } = string.Empty;
        public string Profile { get; set; } = string.Empty;
        public string DefaultTablespace { get; set; } = string.Empty;
        public string TemporaryTablespace { get; set; } = string.Empty;
        public DateTime Created { get; set; }
    }
}
