using BLL.Security;
using BLL.Services.Implementations;
using BLL.Services.Interfaces;
using DAL.Repositories.Implementations;
using GUI.Interfaces;
using System;

namespace GUI.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IAuthService _authService;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _authService = new AuthService(new AuthRepo());

            // 1. Lắng nghe sự kiện khi Form Main bắt đầu mở lên
            _view.MainLoad += OnMainLoad;

            _view.OpenUserClicked += OnOpenUserClicked;
            _view.OpenRoleClicked += OnOpenRoleClicked;
            _view.OpenProfileClicked += OnOpenProfileClicked;
            _view.OpenGrantClicked += OnOpenGrantClicked;
            _view.OpenDemoClicked += OnOpenDemoClicked;
            _view.LogoutClicked += OnLogoutClicked;
        }

        // 2. Hàm này sẽ tự động chạy khi Form Main Load xong
        private void OnMainLoad(object sender, EventArgs e)
        {
            ApplyMainSecurity();
            LoadUserDashboardData();
        }

        private void ApplyMainSecurity()
        {
            // Kiểm tra xem có phải là Admin
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
            bool hasGrantable = _authService.HasGrantablePrivileges();

            bool canOpenGrantForm = isAdmin ||
                                    SessionContext.HasPrivilege("GRANT ANY ROLE") ||
                                    SessionContext.HasPrivilege("GRANT ANY PRIVILEGE") ||
                                    hasGrantable; 

            _view.SetGrantMenuVisible(canOpenGrantForm);

            // Nút Demo Table
            _view.SetDemoTableMenuVisible(true);
        }
        private void LoadUserDashboardData()
        {
            try
            {
                string currentUsername = SessionContext.CurrentUsername;
                if (string.IsNullOrEmpty(currentUsername)) return;

                var userInfo = _authService.GetUserDashboardInfo(currentUsername);
                _view.DisplayUserDashboard(userInfo);

                _view.DisplayUserRoles(_authService.GetUserRoles());
                _view.DisplayUserSystemPrivileges(_authService.GetUserSystemPrivileges());
                _view.DisplayUserObjectPrivileges(_authService.GetUserObjectPrivileges());
                _view.DisplayUserQuotas(_authService.GetUserQuotas());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi tải thông tin cá nhân:\n" + ex.Message,
                                             "Thông báo lỗi",
                                             System.Windows.Forms.MessageBoxButtons.OK,
                                             System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        private void OnOpenUserClicked(object sender, EventArgs e) => _view.ShowUserForm();
        private void OnOpenRoleClicked(object sender, EventArgs e) => _view.ShowRoleForm();
        private void OnOpenProfileClicked(object sender, EventArgs e) => _view.ShowProfileForm();
        private void OnOpenGrantClicked(object sender, EventArgs e) => _view.ShowGrantForm();
        private void OnOpenDemoClicked(object sender, EventArgs e) => _view.ShowDemoForm();
        private void OnLogoutClicked(object sender, EventArgs e)
        {
            try
            {
                SessionContext.ClearSession();

                DAL.Providers.OracleConnectionManager.CurrentConnectionString = null;

                _view.RestartApplication();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đăng xuất: " + ex.Message);
            }
        }
    }

}