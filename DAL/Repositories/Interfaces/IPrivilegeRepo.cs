using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IPrivilegeRepo
    {
        // ===== SYSTEM PRIVILEGE =====
        // Lấy danh sách tất cả system privilege đang được cấp
        DataTable GetAllSystemPrivileges();

        // Gán system privilege cho user/role
        void GrantSystemPrivilege(string privilege, string grantee, bool withAdminOption);

        // Thu hồi system privilege từ user/role
        void RevokeSystemPrivilege(string privilege, string grantee);

        // ===== OBJECT PRIVILEGE (TABLE) =====
        // Lấy danh sách tất cả object privilege đang được cấp
        DataTable GetAllObjectPrivileges();

        // Gán object privilege trên table cho user/role
        void GrantObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee, bool withGrantOption);

        // Thu hồi object privilege trên table từ user/role
        void RevokeObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee);

        // ===== OBJECT PRIVILEGE (COLUMN) =====
        // Gán object privilege trên column cho user/role
        void GrantObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee, bool withGrantOption);

        // Thu hồi object privilege trên column từ user/role
        void RevokeObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee);

        // ===== ROLE GRANT =====
        // Lấy danh sách tất cả role đang được gán
        DataTable GetAllRoleGrants();

        // Gán role cho user/role
        void GrantRole(string roleName, string grantee, bool withAdminOption);

        // Thu hồi role từ user/role
        void RevokeRole(string roleName, string grantee);

        // ===== HỖ TRỢ =====
        // Lấy danh sách tất cả user trong Oracle
        DataTable GetAllUsers();

        // Lấy danh sách tất cả role trong Oracle
        DataTable GetAllRoles();

        // Lấy danh sách tất cả table trong Oracle
        DataTable GetAllTables();

        // Lấy danh sách tất cả column của một table
        DataTable GetColumnsOfTable(string tableOwner, string tableName);
    }
}
