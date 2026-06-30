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
            _presenter = new CreateProfilePresenter(this);
        }
        public string ProfileName => txtProfileName.Text.Trim().ToUpper();

        public string FailedLoginAttempts =>
            GetLimitValue(cboFailedLoginType, numFailedLogin);

        public string PasswordLifeTime =>
            GetLimitValue(cboPasswordLifeType, numPasswordLife);

        public string SessionsPerUser =>
            GetLimitValue(cboSessionsType, numSessions);

        public string PasswordLockTime =>
            GetLimitValue(cboPasswordLockType, numPasswordLock);

        public string PasswordGraceTime =>
            GetLimitValue(cboPasswordGraceType, numPasswordGrace);

        public string ConnectTime =>
            GetLimitValue(cboConnectTimeType, numConnectTime);

        public string IdleTime =>
            GetLimitValue(cboIdleTimeType, numIdleTime);


        public event EventHandler? CreateClicked;
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
            InitCombo(cboFailedLoginType, numFailedLogin);
            InitCombo(cboPasswordLifeType, numPasswordLife);
            InitCombo(cboSessionsType, numSessions);
            InitCombo(cboPasswordLockType, numPasswordLock);
            InitCombo(cboPasswordGraceType, numPasswordGrace);
            InitCombo(cboConnectTimeType, numConnectTime);
            InitCombo(cboIdleTimeType, numIdleTime);

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
        private void InitCombo(ComboBox cbo, NumericUpDown num)
        {
            cbo.Items.Clear();
            cbo.Items.Add("DEFAULT");
            cbo.Items.Add("UNLIMITED");
            cbo.Items.Add("VALUE");
            cbo.SelectedIndex = 0;

            num.Enabled = false;

            cbo.SelectedIndexChanged += (s, e) =>
            {
                num.Enabled = cbo.Text == "VALUE";
            };
        }
       private string GetLimitValue(ComboBox cbo, NumericUpDown num)
        {
            if (cbo.Text == "DEFAULT")
                return "DEFAULT";

            if (cbo.Text == "UNLIMITED")
                return "UNLIMITED";

            return ((int)num.Value).ToString();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboFailedLoginType_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
