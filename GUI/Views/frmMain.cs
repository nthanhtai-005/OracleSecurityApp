using DTO;
using GUI.Interfaces;
using GUI.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class frmMain : Form, IMainView
    {
        private readonly MainPresenter _presenter;
        public frmMain()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
        }
        public event EventHandler MainLoad;

        // 1. Khai báo các sự kiện click theo hợp đồng
        public event EventHandler OpenUserClicked;
        public event EventHandler OpenRoleClicked;
        public event EventHandler OpenProfileClicked;
        public event EventHandler OpenGrantClicked;
        public event EventHandler OpenDemoClicked;

        private void frmMain_Load(object sender, EventArgs e)
        {
            MainLoad?.Invoke(this, EventArgs.Empty);
        }
        // 2. Bắt sự kiện người dùng bấm nút trên giao diện và ném cho Presenter
        private void btnUser_Click(object sender, EventArgs e) => OpenUserClicked?.Invoke(this, EventArgs.Empty);
        private void btnRole_Click(object sender, EventArgs e) => OpenRoleClicked?.Invoke(this, EventArgs.Empty);
        private void btnProfile_Click(object sender, EventArgs e) => OpenProfileClicked?.Invoke(this, EventArgs.Empty);
        private void btnGrant_Click(object sender, EventArgs e) => OpenGrantClicked?.Invoke(this, EventArgs.Empty);
        private void btnDemo_Click(object sender, EventArgs e) => OpenDemoClicked?.Invoke(this, EventArgs.Empty);

        // 3. Thực thi các hàm Ẩn/Hiện nút
        public void SetUserMenuVisible(bool isVisible) => btnUser.Visible = isVisible;
        public void SetRoleMenuVisible(bool isVisible) => btnRole.Visible = isVisible;
        public void SetProfileMenuVisible(bool isVisible) => btnProfile.Visible = isVisible;
        public void SetGrantMenuVisible(bool isVisible) => btnGrant.Visible = isVisible;
        public void SetDemoTableMenuVisible(bool isVisible) => btnDemo.Visible = isVisible;

        // 4. Thực thi các lệnh MỞ FORM (Dùng ShowDialog để mở dạng cửa sổ Pop-up)
        public void ShowUserForm() { new frmUser().ShowDialog(); }
        public void ShowRoleForm() { new frmRole().ShowDialog(); }
        public void ShowProfileForm() { new frmProfile().ShowDialog(); }
        public void ShowGrantForm() { new frmGrant().ShowDialog(); }
        public void ShowDemoForm() { new frmDemoTable().ShowDialog(); }
        public void DisplayUserDashboard(UserDashboardModel userInfo)
        {
            if (userInfo == null) return;

            lblWelcome.Text = $"Chào mừng, {userInfo.FullName}!";
            lblUsername.Text = $"Username: {userInfo.Username}";
            lblEmail.Text = $"Email: {userInfo.Email}";
            lblJoinDate.Text = $"Ngày tham gia: {userInfo.CreatedDate}";

            lblStatus.Text = $"Trạng thái: {userInfo.AccountStatus}";
            lblLockDate.Text = $"Ngày khóa: {userInfo.LockDate}";
            lblProfile.Text = $"Profile: {userInfo.Profile}";
            lblDefaultTs.Text = $"Default TS: {userInfo.DefaultTablespace}";
            lblTempTs.Text = $"Temp TS: {userInfo.TemporaryTablespace}";
        }

        public void DisplayUserRoles(DataTable data)
        {
            dgvUserRoles.DataSource = data;
            if (dgvUserRoles.Columns.Count >= 3)
            {
                dgvUserRoles.Columns[0].HeaderText = "Tên Role";
                dgvUserRoles.Columns[1].HeaderText = "Cấp trực tiếp (YES/NO)";
                dgvUserRoles.Columns[2].HeaderText = "Quyền gán cho người khác (Admin Option)";
            }
            dgvUserRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisplayUserSystemPrivileges(DataTable data)
        {
            dgvUserSysPrivs.DataSource = data;
            if (dgvUserSysPrivs.Columns.Count >= 3)
            {
                dgvUserSysPrivs.Columns[0].HeaderText = "Tên Quyền Hệ Thống";
                dgvUserSysPrivs.Columns[1].HeaderText = "Phương thức cấp quyền";
                dgvUserSysPrivs.Columns[2].HeaderText = "Quyền gán tiếp";
            }
            dgvUserSysPrivs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisplayUserObjectPrivileges(DataTable data)
        {
            dgvUserObjPrivs.DataSource = data;
            if (dgvUserObjPrivs.Columns.Count >= 4)
            {
                dgvUserObjPrivs.Columns[0].HeaderText = "Tên Bảng / Đối tượng";
                dgvUserObjPrivs.Columns[1].HeaderText = "Thao tác (Quyền)";
                dgvUserObjPrivs.Columns[2].HeaderText = "Nguồn cấp";
                dgvUserObjPrivs.Columns[3].HeaderText = "Quyền cấp tiếp (Grant Option)";
            }
            dgvUserObjPrivs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisplayUserQuotas(DataTable data)
        {
            dgvUserQuotas.DataSource = data;
            if (dgvUserQuotas.Columns.Count >= 3)
            {
                dgvUserQuotas.Columns[0].HeaderText = "Tên Tablespace";
                dgvUserQuotas.Columns[1].HeaderText = "Đã sử dụng (Bytes)";
                dgvUserQuotas.Columns[2].HeaderText = "Giới hạn (Unlimited/Bytes)";
            }
            dgvUserQuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public event EventHandler LogoutClicked;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Báo cho Presenter biết người dùng muốn đăng xuất
                LogoutClicked?.Invoke(this, EventArgs.Empty);
            }
        }
        public void RestartApplication()
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
