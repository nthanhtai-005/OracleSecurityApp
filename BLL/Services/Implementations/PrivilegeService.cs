using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Security;
using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementations
{
    public class PrivilegeService : IPrivilegeService
    {
        private readonly IPrivilegeRepo _privilegeRepo;

        public PrivilegeService(IPrivilegeRepo privilegeRepo)
        {
            _privilegeRepo = privilegeRepo;
        }

        // ===== SYSTEM PRIVILEGE =====
        public DataTable GetAllSystemPrivileges()
        {
            return _privilegeRepo.GetAllSystemPrivileges();
        }

        public void GrantSystemPrivilege(string privilege, string grantee, bool withAdminOption)
        {
            if (!SessionContext.HasPrivilege("GRANT ANY PRIVILEGE") &&
                !SessionContext.HasPrivilege("DBA") &&
                SessionContext.CurrentUsername?.ToUpper() != "ADMIN_BM")
                throw new UnauthorizedAccessException("Bạn không có quyền GRANT ANY PRIVILEGE.");

            _privilegeRepo.GrantSystemPrivilege(privilege, grantee, withAdminOption);
        }

        public void RevokeSystemPrivilege(string privilege, string grantee)
        {
            if (!SessionContext.HasPrivilege("GRANT ANY PRIVILEGE") &&
                !SessionContext.HasPrivilege("DBA") &&
                SessionContext.CurrentUsername?.ToUpper() != "ADMIN_BM")
                throw new UnauthorizedAccessException("Bạn không có quyền REVOKE system privilege.");

            _privilegeRepo.RevokeSystemPrivilege(privilege, grantee);
        }

        // ===== OBJECT PRIVILEGE (TABLE) =====
        public DataTable GetAllObjectPrivileges()
        {
            return _privilegeRepo.GetAllObjectPrivileges();
        }

        public void GrantObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee, bool withGrantOption)
        {
            _privilegeRepo.GrantObjectPrivilegeOnTable(privilege, tableName, tableOwner, grantee, withGrantOption);
        }

        public void RevokeObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee)
        {
            _privilegeRepo.RevokeObjectPrivilegeOnTable(privilege, tableName, tableOwner, grantee);
        }

        // ===== OBJECT PRIVILEGE (COLUMN) =====
        public void GrantObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee, bool withGrantOption)
        {
            // WITH GRANT OPTION không được hỗ trợ cho column privilege trong Oracle
            _privilegeRepo.GrantObjectPrivilegeOnColumn(privilege, tableName, tableOwner, columnName, grantee, withGrantOption);
        }

        public void RevokeObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee)
        {
            _privilegeRepo.RevokeObjectPrivilegeOnColumn(privilege, tableName, tableOwner, columnName, grantee);
        }

        // ===== ROLE GRANT =====
        public DataTable GetAllRoleGrants()
        {
            return _privilegeRepo.GetAllRoleGrants();
        }

        public void GrantRole(string roleName, string grantee, bool withAdminOption)
        {
            if (!SessionContext.HasPrivilege("GRANT ANY ROLE") &&
                !SessionContext.HasPrivilege("DBA") &&
                SessionContext.CurrentUsername?.ToUpper() != "ADMIN_BM")
                throw new UnauthorizedAccessException("Bạn không có quyền GRANT ANY ROLE.");

            _privilegeRepo.GrantRole(roleName, grantee, withAdminOption);
        }

        public void RevokeRole(string roleName, string grantee)
        {
            if (!SessionContext.HasPrivilege("GRANT ANY ROLE") &&
                !SessionContext.HasPrivilege("DBA") &&
                SessionContext.CurrentUsername?.ToUpper() != "ADMIN_BM")
                throw new UnauthorizedAccessException("Bạn không có quyền REVOKE role.");

            _privilegeRepo.RevokeRole(roleName, grantee);
        }

        // ===== HỖ TRỢ =====
        public DataTable GetAllUsers()
        {
            return _privilegeRepo.GetAllUsers();
        }

        public DataTable GetAllRoles()
        {
            return _privilegeRepo.GetAllRoles();
        }

        public DataTable GetAllTables()
        {
            return _privilegeRepo.GetAllTables();
        }

        public DataTable GetColumnsOfTable(string tableOwner, string tableName)
        {
            return _privilegeRepo.GetColumnsOfTable(tableOwner, tableName);
        }
    }
}
