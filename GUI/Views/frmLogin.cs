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
    public partial class frmLogin : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;
        public frmLogin()
        {
            InitializeComponent();
            // Giao quyền cho Presenter quản lý form này
            _presenter = new LoginPresenter(this);
        }
        // 1. Cung cấp dữ liệu
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        // 2. Khai báo sự kiện
        public event EventHandler LoginClicked;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }
        // 4. Hàm hiển thị hộp thoại
        public void ShowMessage(string message, bool isError = false)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }

        // 5. Hàm chuyển sang Form Main (Presenter sẽ gọi hàm này khi login đúng)
        public void GoToMainForm()
        {
            frmMain mainForm = new frmMain();
            this.Hide();           // Ẩn form Login
            mainForm.ShowDialog(); // Mở form Main lên
            this.Close();          // Tắt hẳn app khi form Main bị đóng
        }
    }
}
