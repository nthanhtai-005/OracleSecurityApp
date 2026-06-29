using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.Implementations
{
    public class PrivilegeRepo : IPrivilegeRepo
    {
        private readonly DbExecutor _dbExecutor;

        public PrivilegeRepo()
        {
            _dbExecutor = new DbExecutor();
        }

        // ===== SYSTEM PRIVILEGE =====
        public DataTable GetAllSystemPrivileges()
        {
            string sql = @"SELECT GRANTEE, PRIVILEGE, ADMIN_OPTION 
                                   FROM DBA_SYS_PRIVS 
                                   WHERE GRANTEE IN (SELECT USERNAME FROM ADMIN_BM.APP_USERS)
                                   ORDER BY GRANTEE, PRIVILEGE";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public void GrantSystemPrivilege(string privilege, string grantee, bool withAdminOption)
        {
            string option = withAdminOption ? " WITH ADMIN OPTION" : "";
            string sql = $"GRANT {privilege} TO {grantee}{option}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        public void RevokeSystemPrivilege(string privilege, string grantee)
        {
            string sql = $"REVOKE {privilege} FROM {grantee}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        // ===== OBJECT PRIVILEGE (TABLE) =====
        public DataTable GetAllObjectPrivileges()
        {
            string sql = @"SELECT GRANTEE, PRIVILEGE, OWNER, TABLE_NAME, GRANTOR, GRANTABLE, HIERARCHY
                                   FROM DBA_TAB_PRIVS 
                                   WHERE GRANTEE IN (SELECT USERNAME FROM ADMIN_BM.APP_USERS)
                                   ORDER BY GRANTEE, TABLE_NAME, PRIVILEGE";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public void GrantObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee, bool withGrantOption)
        {
            string option = withGrantOption ? " WITH GRANT OPTION" : "";
            string sql = $"GRANT {privilege} ON {tableOwner}.{tableName} TO {grantee}{option}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        public void RevokeObjectPrivilegeOnTable(string privilege, string tableName, string tableOwner, string grantee)
        {
            string sql = $"REVOKE {privilege} ON {tableOwner}.{tableName} FROM {grantee}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        // ===== OBJECT PRIVILEGE (COLUMN) =====
        public void GrantObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee, bool withGrantOption)
        {
            // Lưu ý: WITH GRANT OPTION không được hỗ trợ cho column privilege
            string sql = $"GRANT {privilege} ({columnName}) ON {tableOwner}.{tableName} TO {grantee}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        public void RevokeObjectPrivilegeOnColumn(string privilege, string tableName, string tableOwner, string columnName, string grantee)
        {
            string sql = $"REVOKE {privilege} ({columnName}) ON {tableOwner}.{tableName} FROM {grantee}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        // ===== ROLE GRANT =====
        public DataTable GetAllRoleGrants()
        {
            string sql = @"SELECT GRANTEE, GRANTED_ROLE, ADMIN_OPTION, DEFAULT_ROLE
                                   FROM DBA_ROLE_PRIVS
                                   WHERE GRANTEE IN (SELECT USERNAME FROM ADMIN_BM.APP_USERS)
                                   ORDER BY GRANTEE, GRANTED_ROLE";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public void GrantRole(string roleName, string grantee, bool withAdminOption)
        {
            string option = withAdminOption ? " WITH ADMIN OPTION" : "";
            string sql = $"GRANT {roleName} TO {grantee}{option}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        public void RevokeRole(string roleName, string grantee)
        {
            string sql = $"REVOKE {roleName} FROM {grantee}";
            _dbExecutor.ExecuteNonQuery(sql);
        }

        // ===== HỖ TRỢ =====
        public DataTable GetAllUsers()
        {
            string sql = "SELECT USERNAME FROM ADMIN_BM.APP_USERS ORDER BY USERNAME";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public DataTable GetAllRoles()
        {
            string sql = "SELECT ROLE FROM DBA_ROLES WHERE ORACLE_MAINTAINED = 'N' ORDER BY ROLE";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public DataTable GetAllTables()
        {
            string sql = "SELECT OWNER, TABLE_NAME FROM DBA_TABLES WHERE OWNER = 'ADMIN_BM' ORDER BY TABLE_NAME";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public DataTable GetColumnsOfTable(string tableOwner, string tableName)
        {
            string sql = $"SELECT COLUMN_NAME FROM DBA_TAB_COLUMNS WHERE OWNER = '{tableOwner.ToUpper()}' AND TABLE_NAME = '{tableName.ToUpper()}' ORDER BY COLUMN_ID";
            return _dbExecutor.ExecuteQuery(sql);
        }
    }
}
