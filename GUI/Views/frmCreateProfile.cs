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
using DAL.Repositories.Implementations;
using GUI.Presenters;
using MODELS;
using BLL.Services.Implementations;
namespace GUI.Views
{
    public partial class frmCreateProfile : Form, ICreateProfileView
    {
        private CreateProfilePresenter _presenter;

        public frmCreateProfile()
        {
            InitializeComponent();

            string connectionString =
                "User Id=SYS;Password=123;Data Source=localhost:1521/FREEPDB1;DBA Privilege=SYSDBA";

            var repo = new UserRepository(connectionString);
            var service = new UserService(repo);

            _presenter = new CreateProfilePresenter(this, service);
        }
        public string ProfileName => txtProfileName.Text;
        public int FailedLoginAttempts => (int)numFailedLogin.Value;

        public int PasswordLifeTime => (int)numPasswordLife.Value;

        public int SessionsPerUser => (int)numSessions.Value;
        public int PasswordLockTime => (int)numPasswordLock.Value;

        public int PasswordGraceTime => (int)numPasswordGrace.Value;

        public int ConnectTime => (int)numConnectTime.Value;

        public int IdleTime => (int)numIdleTime.Value;

        public event EventHandler CreateClicked;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void frmCreateProfile_Load(object sender, EventArgs e)
        {
            numFailedLogin.Minimum = 1;
            numPasswordLife.Minimum = 1;
            numPasswordLock.Minimum = 1;
            numPasswordGrace.Minimum = 1;
            numSessions.Minimum = 1;
            numConnectTime.Minimum = 1;
            numIdleTime.Minimum = 1;

            numFailedLogin.Maximum = 9999;
            numPasswordLife.Maximum = 9999;
            numPasswordLock.Maximum = 9999;
            numPasswordGrace.Maximum = 9999;
            numSessions.Maximum = 9999;
            numConnectTime.Maximum = 9999;
            numIdleTime.Maximum = 9999;

            numFailedLogin.Value = 3;
            numPasswordLife.Value = 180;
            numPasswordLock.Value = 1;
            numPasswordGrace.Value = 7;
            numSessions.Value = 2;
            numConnectTime.Value = 60;
            numIdleTime.Value = 15;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
