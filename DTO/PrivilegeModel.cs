using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PrivilegeModel
    {
        // Tên quyền (ví dụ: CREATE TABLE, SELECT ANY TABLE...)
        public string PrivilegeName { get; set; }

        // Đối tượng được cấp quyền (user hoặc role)
        public string Grantee { get; set; }

        // Người cấp quyền
        public string Grantor { get; set; }

        // Có được phép cấp lại cho người khác không (YES/NO)
        public string AdminOption { get; set; }
    }
}
