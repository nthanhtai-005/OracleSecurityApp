using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Interfaces;
using GUI.Presenters;

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
        public void ShowUserForm() { new frmUserManagement().ShowDialog(); }
        public void ShowRoleForm() { new frmRole().ShowDialog(); }
        public void ShowProfileForm() { new frmProfile().ShowDialog(); }
        public void ShowGrantForm() { new frmGrant().ShowDialog(); }
        public void ShowDemoForm() { new frmDemoTable().ShowDialog(); }

    }
}
