using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleModel
    {
        public string RoleName { get; set; }
        public bool HasPassword { get; set; }
        public string Password { get; set; }
    }
}
