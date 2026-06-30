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
            _presenter = new CreateUserPresenter(this);
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
        public string TemporaryTablespace
        {
            get => cboTemporaryTablespace.Text;
        }

        public int QuotaMB
        {
            get => (int)numericUpDown1.Value;
        }

        public string Password { get => txtPassword.Text; }
        public string Profile { get => cboProfile.Text; }

        public string DefaultTablespace
        {
            get => cboTablespace.Text;
        }

        public string Fullname => txtFullname.Text.Trim();

        public string Email => txtEmail.Text.Trim();
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
            LoadComboboxData();
        }

        private void LoadComboboxData()
        {
            try
            {
                cboTablespace.Items.Clear();
                cboTemporaryTablespace.Items.Clear();
                cboProfile.Items.Clear();

                var tablespaces = _presenter.GetTablespaces();
                var tempTablespaces = _presenter.GetTemporaryTablespaces();
                var profiles = _presenter.GetProfiles();

                foreach (var item in tablespaces)
                    cboTablespace.Items.Add(item);

                foreach (var item in tempTablespaces)
                    cboTemporaryTablespace.Items.Add(item);

                foreach (var item in profiles)
                    cboProfile.Items.Add(item);

                if (cboTablespace.Items.Count > 0)
                    cboTablespace.SelectedIndex = 0;

                if (cboTemporaryTablespace.Items.Count > 0)
                    cboTemporaryTablespace.SelectedIndex = 0;

                if (cboProfile.Items.Count > 0)
                    cboProfile.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
