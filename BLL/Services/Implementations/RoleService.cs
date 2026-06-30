using DAL.Repositories.Implementations;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implementations
{
    public class RoleService
    {
        private readonly RoleRepo _roleRepo;

        public RoleService()
        {
            _roleRepo = new RoleRepo();
        }

        public void CreateNewRole(RoleModel role)
        {
            if (string.IsNullOrWhiteSpace(role.RoleName))
                throw new Exception("Tên Role không được để trống.");

            if (!_roleRepo.CheckSystemPrivilege("CREATE ROLE"))
                throw new Exception("Bạn không có đặc quyền CREATE ROLE để thực hiện thao tác này!");

            _roleRepo.CreateRole(role);
        }

        public void DeleteRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                throw new Exception("Vui lòng chọn Role để xóa.");

            if (!_roleRepo.CheckSystemPrivilege("DROP ANY ROLE"))
                throw new Exception("Bạn không có đặc quyền DROP ANY ROLE để thực hiện thao tác này!");

            _roleRepo.DropRole(roleName);
        }

        public DataTable GetRolesList()
        {
            return _roleRepo.GetAllRoles();
        }
        public void UpdateRolePassword(string roleName, string newPassword)
        {
            if (string.IsNullOrEmpty(roleName))
                throw new Exception("Vui lòng nhập Tên Role cần đổi mật khẩu.");

            if (string.IsNullOrEmpty(newPassword))
                throw new Exception("Mật khẩu mới không được để trống.");

            _roleRepo.UpdateRolePassword(roleName, newPassword);
        }
    }
}
