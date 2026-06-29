using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IPrivilegeService
    {
        // ===== SYSTEM PRIVILEGE =====
        DataTable GetAllSystemPrivileges();
        void GrantSystemPrivilege(string privilege, string grantee, bool withAdminOption);
        void RevokeSystemPrivilege(string privilege, string grantee);

        // ===== OBJECT PRIVILEGE (TABLE) =====
        DataTable GetAllObjectPrivileges();
        void GrantObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee, bool withGrantOption);
        void RevokeObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee);

        // ===== OBJECT PRIVILEGE (COLUMN) =====
        void GrantObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee, bool withGrantOption);
        void RevokeObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee);

        // ===== ROLE GRANT =====
        DataTable GetAllRoleGrants();
        void GrantRole(string roleName, string grantee, bool withAdminOption);
        void RevokeRole(string roleName, string grantee);

        // ===== HỖ TRỢ =====
        DataTable GetAllUsers();
        DataTable GetAllRoles();
        DataTable GetAllTables();
        DataTable GetColumnsOfTable(string tableOwner, string tableName);
    }
}
