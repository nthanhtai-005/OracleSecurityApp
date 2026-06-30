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

            InitCombo(cboFailedLoginType, numFailedLogin);
            InitCombo(cboPasswordLifeType, numPasswordLife);
            InitCombo(cboSessionsType, numPasswordLock);
            InitCombo(cboPasswordGraceType, numPasswordGrace);
            InitCombo(cboSessionsType, numSessions);
            InitCombo(cboConnectTimeType, numConnectTime);
            InitCombo(cboIdleTimeType, numIdleTime);

            txtProfileName.Text = request.ProfileName;

            SetLimitValue(cboFailedLoginType, numFailedLogin, request.FailedLoginAttempts);
            SetLimitValue(cboPasswordLifeType, numPasswordLife, request.PasswordLifeTime);
            SetLimitValue(cboSessionsType, numPasswordLock, request.PasswordLockTime);
            SetLimitValue(cboPasswordGraceType, numPasswordGrace, request.PasswordGraceTime);
            SetLimitValue(cboSessionsType, numSessions, request.SessionsPerUser);
            SetLimitValue(cboConnectTimeType, numConnectTime, request.ConnectTime);
            SetLimitValue(cboIdleTimeType, numIdleTime, request.IdleTime);

            _presenter = new EditProfilePresenter(this);
        }

        public string ProfileName => txtProfileName.Text.Trim().ToUpper();

        public string FailedLoginAttempts =>
            GetLimitValue(cboFailedLoginType, numFailedLogin);

        public string PasswordLifeTime =>
            GetLimitValue(cboPasswordLifeType, numPasswordLife);

        public string PasswordLockTime =>
            GetLimitValue(cboSessionsType, numPasswordLock);

        public string PasswordGraceTime =>
            GetLimitValue(cboPasswordGraceType, numPasswordGrace);

        public string SessionsPerUser =>
            GetLimitValue(cboSessionsType, numSessions);

        public string ConnectTime =>
            GetLimitValue(cboConnectTimeType, numConnectTime);

        public string IdleTime =>
            GetLimitValue(cboIdleTimeType, numIdleTime);
        public event EventHandler? CreateClicked;

        private void InitCombo(ComboBox cbo, NumericUpDown num)
        {
            cbo.Items.Clear();
            cbo.Items.Add("DEFAULT");
            cbo.Items.Add("UNLIMITED");
            cbo.Items.Add("VALUE");

            cbo.SelectedIndex = 0;

            num.Minimum = 0;
            num.Maximum = 9999;
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

        private void SetLimitValue(ComboBox cbo, NumericUpDown num, string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.ToUpper() == "DEFAULT")
            {
                cbo.Text = "DEFAULT";
                num.Enabled = false;
                num.Value = 0;
                return;
            }

            if (value.ToUpper() == "UNLIMITED")
            {
                cbo.Text = "UNLIMITED";
                num.Enabled = false;
                num.Value = 0;
                return;
            }

            cbo.Text = "VALUE";
            num.Enabled = true;

            if (decimal.TryParse(value, out decimal number))
                num.Value = number;
            else
                num.Value = 0;
        }

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

        private void numFailedLogin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cboPasswordLockType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
