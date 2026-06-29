using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ObjectPrivilegeModel
    {
        // Tên quyền (SELECT, INSERT, DELETE)
        public string PrivilegeName { get; set; }

        // Đối tượng được cấp quyền (user hoặc role)
        public string Grantee { get; set; }

        // Người cấp quyền
        public string Grantor { get; set; }

        // Tên table được cấp quyền
        public string TableName { get; set; }

        // Tên column (nếu cấp quyền trên column, để null nếu cấp trên cả table)
        public string ColumnName { get; set; }

        // Có được phép cấp lại cho người khác không (YES/NO)
        // Lưu ý: Object privilege chỉ hỗ trợ WITH GRANT OPTION, không có WITH ADMIN OPTION
        public string GrantOption { get; set; }
    }
}
