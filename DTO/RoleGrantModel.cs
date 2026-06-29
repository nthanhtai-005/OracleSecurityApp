using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleGrantModel
    {
        // Tên role được gán
        public string RoleName { get; set; }

        // Đối tượng được gán role (user hoặc role)
        public string Grantee { get; set; }

        // Có được phép gán role này cho người khác không (YES/NO)
        public string AdminOption { get; set; }

        // Role có đang được bật không (YES/NO)
        public string DefaultRole { get; set; }
    }
}
