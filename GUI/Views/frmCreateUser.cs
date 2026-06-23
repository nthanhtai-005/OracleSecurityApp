using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories.Implementations;
using GUI.Interfaces;
using GUI.Presenters;
using MODELS;
using BLL.Services.Implementations;
namespace GUI.Views
{
    public partial class frmCreateUser : Form, ICreateUserView
    {
        private CreateUserPresenter _presenter;
        public frmCreateUser()
        {
            InitializeComponent();
            string connectionString = "User Id=SYS;Password=123;Data Source=localhost:1521/FREEPDB1;DBA Privilege=SYSDBA";

            var repo =
                new UserRepository(connectionString);

            var service =
                new UserService(repo);

            _presenter =
                new CreateUserPresenter(
                    this,
                    service);
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { this.Close(); }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateClicked?.Invoke(this, EventArgs.Empty);
        }
        public string Username
        {
            get => txtUsername.Text.Trim();
        }

        public string Password { get => txtPassword.Text; }
        public string Profile { get => cboProfile.Text; }

        public string DefaultTablespace
        {
            get => cboTablespace.Text;
        }
        public event EventHandler? CreateClicked;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
