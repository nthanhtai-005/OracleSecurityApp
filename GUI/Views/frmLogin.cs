using System;
using System.Windows.Forms;
using GUI.Interfaces;
using GUI.Presenters;

namespace GUI.Views
{
    public partial class frmLogin : Form, ILoginView
    {
        private LoginPresenter _presenter;

        public frmLogin()
        {
            InitializeComponent();
        }

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public event EventHandler LoginClicked;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message, bool isError = false)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }

        public void GoToMainForm()
        {
            frmMain mainForm = new frmMain();
            this.Hide();           
            mainForm.ShowDialog(); 
            this.Close();          
        }

        private void btnSeedData_Click(object sender, EventArgs e)
        {
            
        }
        public void SetPresenter(LoginPresenter presenter)
        {
            _presenter = presenter;
        }
    }
}