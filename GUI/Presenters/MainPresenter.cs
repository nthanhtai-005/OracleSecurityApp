using BLL.Security;
using BLL.Services;
using GUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;

            ApplyMainSecurity();
            _view.OpenUserClicked += OnOpenUserClicked;
            _view.OpenRoleClicked += OnOpenRoleClicked;
            _view.OpenProfileClicked += OnOpenProfileClicked;
            _view.OpenGrantClicked += OnOpenGrantClicked;
            _view.OpenDemoClicked += OnOpenDemoClicked;
        }

        private void ApplyMainSecurity()
        {
            // 1. Nút Quản lý User (Chỉ cần có 1 trong 3 quyền Tạo, Sửa, Xóa là cho hiện nút mở Form)
            bool canOpenUserForm = SessionContext.HasPrivilege("CREATE USER") ||
                                   SessionContext.HasPrivilege("ALTER USER") ||
                                   SessionContext.HasPrivilege("DROP USER");
            _view.SetUserMenuVisible(canOpenUserForm);

            // 2. Nút Quản lý Role
            bool canOpenRoleForm = SessionContext.HasPrivilege("CREATE ROLE") ||
                                   SessionContext.HasPrivilege("ALTER ANY ROLE") ||
                                   SessionContext.HasPrivilege("DROP ANY ROLE") ||
                                   SessionContext.HasPrivilege("GRANT ANY ROLE");
            _view.SetRoleMenuVisible(canOpenRoleForm);

            // 3. Nút Quản lý Profile
            bool canOpenProfileForm = SessionContext.HasPrivilege("CREATE PROFILE") ||
                                      SessionContext.HasPrivilege("ALTER PROFILE") ||
                                      SessionContext.HasPrivilege("DROP PROFILE");
            _view.SetProfileMenuVisible(canOpenProfileForm);

            // 4. Nút Gán Quyền (Grant)
            // Giả định: Người có quyền GRANT ANY ROLE hoặc GRANT ANY PRIVILEGE thì được mở form này
            bool canOpenGrantForm = SessionContext.HasPrivilege("GRANT ANY ROLE") ||
                                    SessionContext.HasPrivilege("GRANT ANY PRIVILEGE");
            _view.SetGrantMenuVisible(canOpenGrantForm);

            // 5. Nút Demo Table
            // Thường thì bảng Demo ai cũng có thể bấm vào xem thử (để bị văng lỗi thiếu quyền, demo cho giảng viên xem)
            // Nên ta có thể luôn set là True, hoặc check quyền SELECT ANY TABLE
            _view.SetDemoTableMenuVisible(true);
        }
        private void OnOpenUserClicked(object sender, EventArgs e) => _view.ShowUserForm();
        private void OnOpenRoleClicked(object sender, EventArgs e) => _view.ShowRoleForm();
        private void OnOpenProfileClicked(object sender, EventArgs e) => _view.ShowProfileForm();
        private void OnOpenGrantClicked(object sender, EventArgs e) => _view.ShowGrantForm();
        private void OnOpenDemoClicked(object sender, EventArgs e) => _view.ShowDemoForm();
    }
}
