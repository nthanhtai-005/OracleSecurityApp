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
    public partial class frmEditProfile : Form, IEditProfileView
    {
        private EditProfilePresenter _presenter;

        public frmEditProfile(CreateProfileRequest request)
        {
            InitializeComponent();
            numFailedLogin.Maximum = 9999;
            numPasswordLife.Maximum = 9999;
            numPasswordLock.Maximum = 9999;
            numPasswordGrace.Maximum = 9999;
            numSessions.Maximum = 9999;
            numConnectTime.Maximum = 9999;
            numIdleTime.Maximum = 9999;

            txtProfileName.Text = request.ProfileName;
            numFailedLogin.Value = request.FailedLoginAttempts;
            numPasswordLife.Value = request.PasswordLifeTime;
            numPasswordLock.Value = request.PasswordLockTime;
            numPasswordGrace.Value = request.PasswordGraceTime;
            numSessions.Value = request.SessionsPerUser;
            numConnectTime.Value = request.ConnectTime;
            numIdleTime.Value = request.IdleTime;

            string connectionString =
                "User Id=SYS;Password=123;Data Source=localhost:1521/FREEPDB1;DBA Privilege=SYSDBA";

            var repo = new UserRepository(connectionString);
            var service = new UserService(repo);

            _presenter = new EditProfilePresenter(this, service);
        }

        public string ProfileName => txtProfileName.Text;

        public int FailedLoginAttempts => (int)numFailedLogin.Value;

        public int PasswordLifeTime => (int)numPasswordLife.Value;

        public int PasswordLockTime => (int)numPasswordLock.Value;

        public int PasswordGraceTime => (int)numPasswordGrace.Value;

        public int SessionsPerUser => (int)numSessions.Value;

        public int ConnectTime => (int)numConnectTime.Value;

        public int IdleTime => (int)numIdleTime.Value;

        public event EventHandler? CreateClicked;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
