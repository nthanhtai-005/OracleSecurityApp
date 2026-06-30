using DAL.Providers;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.Repositories.Implementations
{
    public class RoleRepo
    {
        public bool CheckSystemPrivilege(string privilegeName)
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open(); // Chủ động mở kết nối
                string query = "SELECT count(*) FROM session_privs WHERE privilege = :priv";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("priv", privilegeName));
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void CreateRole(RoleModel role)
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();
                using (OracleCommand cmdAlter = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"=true", conn))
                {
                    cmdAlter.ExecuteNonQuery();
                }
                string query = $"CREATE ROLE {role.RoleName}";
                if (role.HasPassword && !string.IsNullOrEmpty(role.Password))
                {
                    query += $" IDENTIFIED BY \"{role.Password}\"";
                }
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DropRole(string roleName)
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();
                using (OracleCommand cmdAlter = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"=true", conn))
                {
                    cmdAlter.ExecuteNonQuery();
                }
                string query = $"DROP ROLE {roleName}";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllRoles()
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();
                string query = "SELECT ROLE, PASSWORD_REQUIRED FROM DBA_ROLES ORDER BY ROLE";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public void UpdateRolePassword(string roleName, string newPassword)
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();

                // Vượt rào bảo mật PDB/CDB
                using (OracleCommand cmdAlter = new OracleCommand("ALTER SESSION SET \"_ORACLE_SCRIPT\"=true", conn))
                {
                    cmdAlter.ExecuteNonQuery();
                }

                // Lệnh đổi mật khẩu Role
                string query = $"ALTER ROLE {roleName} IDENTIFIED BY \"{newPassword}\"";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
