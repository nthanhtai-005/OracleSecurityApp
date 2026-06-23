using BLL.Security;
using GUI.Interfaces;
using System;

namespace GUI.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;

            // 1. Lắng nghe sự kiện khi Form Main bắt đầu mở lên
            _view.MainLoad += OnMainLoad;

            _view.OpenUserClicked += OnOpenUserClicked;
            _view.OpenRoleClicked += OnOpenRoleClicked;
            _view.OpenProfileClicked += OnOpenProfileClicked;
            _view.OpenGrantClicked += OnOpenGrantClicked;
            _view.OpenDemoClicked += OnOpenDemoClicked;
        }

        // 2. Hàm này sẽ tự động chạy khi Form Main Load xong
        private void OnMainLoad(object sender, EventArgs e)
        {
            ApplyMainSecurity();
        }

        private void ApplyMainSecurity()
        {
            // 3. THÊM DÒNG NÀY: Kiểm tra xem có phải là Admin tối cao không
            bool isAdmin = SessionContext.CurrentUsername?.ToUpper() == "ADMIN_BM" || SessionContext.HasPrivilege("DBA");

            // Nút Quản lý User (Thêm isAdmin vào đầu)
            bool canOpenUserForm = isAdmin ||
                                   SessionContext.HasPrivilege("CREATE USER") ||
                                   SessionContext.HasPrivilege("ALTER USER") ||
                                   SessionContext.HasPrivilege("DROP USER");
            _view.SetUserMenuVisible(canOpenUserForm);

            // Nút Quản lý Role
            bool canOpenRoleForm = isAdmin ||
                                   SessionContext.HasPrivilege("CREATE ROLE") ||
                                   SessionContext.HasPrivilege("ALTER ANY ROLE") ||
                                   SessionContext.HasPrivilege("DROP ANY ROLE") ||
                                   SessionContext.HasPrivilege("GRANT ANY ROLE");
            _view.SetRoleMenuVisible(canOpenRoleForm);

            // Nút Quản lý Profile
            bool canOpenProfileForm = isAdmin ||
                                      SessionContext.HasPrivilege("CREATE PROFILE") ||
                                      SessionContext.HasPrivilege("ALTER PROFILE") ||
                                      SessionContext.HasPrivilege("DROP PROFILE");
            _view.SetProfileMenuVisible(canOpenProfileForm);

            // Nút Gán Quyền (Grant)
            bool canOpenGrantForm = isAdmin ||
                                    SessionContext.HasPrivilege("GRANT ANY ROLE") ||
                                    SessionContext.HasPrivilege("GRANT ANY PRIVILEGE");
            _view.SetGrantMenuVisible(canOpenGrantForm);

            // Nút Demo Table
            _view.SetDemoTableMenuVisible(true);
        }

        private void OnOpenUserClicked(object sender, EventArgs e) => _view.ShowUserForm();
        private void OnOpenRoleClicked(object sender, EventArgs e) => _view.ShowRoleForm();
        private void OnOpenProfileClicked(object sender, EventArgs e) => _view.ShowProfileForm();
        private void OnOpenGrantClicked(object sender, EventArgs e) => _view.ShowGrantForm();
        private void OnOpenDemoClicked(object sender, EventArgs e) => _view.ShowDemoForm();
    }
}