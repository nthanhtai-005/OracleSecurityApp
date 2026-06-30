using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Implementations;

namespace BLL.Services.Implementations
{
    public class DemoTableService
    {
        private readonly DemoTableRepo _repo = new DemoTableRepo();

        public Dictionary<string, bool> CheckAccess()
        {
            var rights = new Dictionary<string, bool>
            {
                { "SELECT", false },
                { "INSERT", false },
                { "UPDATE", false }, // Đã thêm quyền Sửa
                { "DELETE", false }
            };

            try
            {
                DataTable dt = _repo.GetTablePrivileges();
                foreach (DataRow row in dt.Rows)
                {
                    string priv = row["PRIVILEGE"].ToString().ToUpper();
                    if (rights.ContainsKey(priv))
                    {
                        rights[priv] = true;
                    }
                }
                return rights;
            }
            catch
            {
                return rights;
            }
        }
        public bool CanAccessTable()
        {
            var privileges = CheckAccess();
            return privileges.ContainsKey("SELECT") && privileges["SELECT"];
        }
        public DataTable LoadData()
        {
            return _repo.GetEmployees();
        }

        public void AddNewEmployee(string username, string fullname, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullname))
                throw new Exception("Tên đăng nhập và Họ tên không được để trống!");

            _repo.InsertEmployee(username, fullname, email);
        }
        public void UpdateEmployee(string username, string fullname, string email)
        {
            if (string.IsNullOrEmpty(username))
                throw new Exception("Vui lòng chọn nhân viên cần cập nhật!");
            if (string.IsNullOrEmpty(fullname))
                throw new Exception("Họ tên không được để trống!");

            _repo.UpdateEmployee(username, fullname, email);
        }

        // ---> THÊM HÀM XÓA <---
        public void DeleteEmployee(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new Exception("Vui lòng chọn nhân viên cần xóa!");

            _repo.DeleteEmployee(username);
        }
    }
}
