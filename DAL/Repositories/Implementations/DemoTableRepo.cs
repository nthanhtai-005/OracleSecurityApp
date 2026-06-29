using DAL.Providers;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations
{
    public class DemoTableRepo
    {
        public DataTable GetTablePrivileges()
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();

                string checkOwnerQuery = "SELECT USER FROM DUAL";
                string currentUser = "";
                using (OracleCommand cmd = new OracleCommand(checkOwnerQuery, conn))
                {
                    currentUser = cmd.ExecuteScalar()?.ToString().ToUpper();
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("PRIVILEGE", typeof(string));

                if (currentUser == "ADMIN_BM")
                {
                    dt.Rows.Add("SELECT");
                    dt.Rows.Add("INSERT");
                    dt.Rows.Add("UPDATE");
                    dt.Rows.Add("DELETE");
                    return dt;
                }

                string query = @"
                    SELECT PRIVILEGE FROM ROLE_TAB_PRIVS 
                    WHERE TABLE_NAME = 'NHANVIEN' 
                      AND ROLE IN (SELECT ROLE FROM SESSION_ROLES)
                    UNION
                    SELECT PRIVILEGE FROM USER_TAB_PRIVS 
                    WHERE TABLE_NAME = 'NHANVIEN'";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable GetEmployees()
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();
                string query = "SELECT USERNAME, FULLNAME, EMAIL FROM ADMIN_BM.NHANVIEN";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        public void InsertEmployee(string username, string fullname, string email)
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO ADMIN_BM.NHANVIEN (USERNAME, FULLNAME, EMAIL) VALUES (:username, :fullname, :email)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("username", username));
                    cmd.Parameters.Add(new OracleParameter("fullname", fullname));
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateEmployee(string username, string fullname, string email)
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();
                // Lệnh cập nhật dựa theo Username (khóa chính)
                string query = "UPDATE NHANVIEN SET FULLNAME = :fullname, EMAIL = :email WHERE USERNAME = :username";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    // Lưu ý: Thứ tự add parameter phải khớp với thứ tự biến trong câu query
                    cmd.Parameters.Add(new OracleParameter("fullname", fullname));
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.Parameters.Add(new OracleParameter("username", username));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(string username)
        {
            OracleConnectionManager dbManager = new OracleConnectionManager();
            using (OracleConnection conn = dbManager.GetConnection())
            {
                conn.Open();
                // Lệnh xóa dựa theo Username
                string query = "DELETE FROM NHANVIEN WHERE USERNAME = :username";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("username", username));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
