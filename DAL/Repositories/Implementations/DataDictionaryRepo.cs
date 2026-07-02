using System.Data;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.Implementations
{
    public class DataDictionaryRepo : IDataDictionaryRepo
    {
        private readonly DbExecutor _dbExecutor;

        public DataDictionaryRepo()
        {
            _dbExecutor = new DbExecutor();
        }

        public DataTable GetPrivilegeManagement()
        {
            string sql = @"
                SELECT GRANTEE, 'SYSTEM' AS PRIVILEGE_TYPE, PRIVILEGE AS PRIVILEGE_NAME, '-' AS OBJECT_NAME, ADMIN_OPTION AS GRANTABLE
                FROM DBA_SYS_PRIVS 
                WHERE GRANTEE IN (SELECT USERNAME FROM ADMIN_BM.APP_USERS) OR GRANTEE IN (SELECT ROLE FROM DBA_ROLES WHERE ORACLE_MAINTAINED='N')
                UNION ALL
                SELECT GRANTEE, 'OBJECT' AS PRIVILEGE_TYPE, PRIVILEGE AS PRIVILEGE_NAME, OWNER || '.' || TABLE_NAME AS OBJECT_NAME, GRANTABLE
                FROM DBA_TAB_PRIVS
                WHERE GRANTEE IN (SELECT USERNAME FROM ADMIN_BM.APP_USERS) OR GRANTEE IN (SELECT ROLE FROM DBA_ROLES WHERE ORACLE_MAINTAINED='N')
                ORDER BY GRANTEE, PRIVILEGE_TYPE";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public DataTable GetRoleManagement()
        {
            string sql = @"
                SELECT DR.ROLE, 
                       NVL(RSP.PRIVILEGE, 'No Sys Privs') AS PRIVILEGE_NAME, 
                       NVL(DRP.GRANTEE, 'No Assigned User') AS ASSIGNED_USER
                FROM DBA_ROLES DR
                LEFT JOIN ROLE_SYS_PRIVS RSP ON DR.ROLE = RSP.ROLE
                LEFT JOIN DBA_ROLE_PRIVS DRP ON DR.ROLE = DRP.GRANTED_ROLE
                WHERE DR.ORACLE_MAINTAINED = 'N'
                ORDER BY DR.ROLE";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public DataTable GetProfileManagement()
        {
            string sql = @"
                SELECT DP.PROFILE, DP.RESOURCE_NAME, DP.LIMIT, 
                       NVL(DU.USERNAME, 'No Assigned User') AS ASSIGNED_USER
                FROM DBA_PROFILES DP
                LEFT JOIN DBA_USERS DU ON DP.PROFILE = DU.PROFILE
                WHERE DP.RESOURCE_NAME IN ('SESSIONS_PER_USER', 'CONNECT_TIME', 'IDLE_TIME')
                ORDER BY DP.PROFILE, DP.RESOURCE_NAME";
            return _dbExecutor.ExecuteQuery(sql);
        }

        public DataTable GetUserManagement()
        {
            string sql = @"
                SELECT 
                    U.USERNAME, 
                    NVL(A.FULLNAME, 'N/A') AS FULLNAME, 
                    NVL(A.EMAIL, 'N/A') AS EMAIL, 
                    U.ACCOUNT_STATUS, 
                    TO_CHAR(U.LOCK_DATE, 'DD/MM/YYYY') AS LOCK_DATE, 
                    TO_CHAR(U.CREATED, 'DD/MM/YYYY') AS CREATED_DATE, 
                    U.DEFAULT_TABLESPACE, 
                    U.TEMPORARY_TABLESPACE, 
                    U.PROFILE,
                    NVL((SELECT LISTAGG(GRANTED_ROLE, ', ') WITHIN GROUP (ORDER BY GRANTED_ROLE) FROM DBA_ROLE_PRIVS WHERE GRANTEE = U.USERNAME), 'None') AS ROLES
                FROM DBA_USERS U
                LEFT JOIN ADMIN_BM.APP_USERS A ON U.USERNAME = A.USERNAME
                WHERE U.ORACLE_MAINTAINED = 'N'
                ORDER BY U.USERNAME";
            return _dbExecutor.ExecuteQuery(sql);
        }
    }
}