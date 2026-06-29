using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Interfaces;
using BLL.Services;
using DTO;
using BLL.Services.Implementations;

namespace GUI.Presenters
{
    public class RolePresenter
    {
        private readonly IRoleView _view;
        private readonly RoleService _roleService;

        public RolePresenter(IRoleView view)
        {
            _view = view;
            _roleService = new RoleService();

            _view.CreateRoleEvent += OnCreateRole;
            _view.DropRoleEvent += OnDropRole;
            _view.LoadRolesEvent += OnLoadRoles;
            _view.UpdateRolePasswordEvent += OnUpdateRolePassword;
        }

        private void OnLoadRoles(object sender, EventArgs e)
        {
            try
            {
                var dt = _roleService.GetRolesList();
                _view.DisplayRoles(dt);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi tải danh sách Role: " + ex.Message, false);
            }
        }

        private void OnCreateRole(object sender, EventArgs e)
        {
            try
            {
                RoleModel newRole = new RoleModel
                {
                    RoleName = _view.RoleName,
                    HasPassword = _view.IsPasswordChecked,
                    Password = _view.Password
                };
                _roleService.CreateNewRole(newRole);
                _view.ShowMessage("Tạo Role thành công!", true);
                OnLoadRoles(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message, false);
            }
        }

        private void OnDropRole(object sender, EventArgs e)
        {
            try
            {
                _roleService.DeleteRole(_view.RoleName);
                _view.ShowMessage("Xóa Role thành công!", true);
                OnLoadRoles(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message, false);
            }
        }
        private void OnUpdateRolePassword(object sender, EventArgs e)
        {
            try
            {
                if (!_view.IsPasswordChecked)
                {
                    _view.ShowMessage("Vui lòng tích chọn 'Có mật khẩu' để tiến hành đổi mật khẩu!", false);
                    return;
                }

                _roleService.UpdateRolePassword(_view.RoleName, _view.Password);
                _view.ShowMessage("Đổi mật khẩu Role thành công!", true);
                OnLoadRoles(this, EventArgs.Empty); // Tải lại lưới sau khi đổi
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi khi đổi mật khẩu: " + ex.Message, false);
            }
        }
    }
}
