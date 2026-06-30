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
using MODELS;
using BLL.Services.Implementations;

namespace GUI.Views
{
    public partial class frmChangePassword : Form
    {
        private string _username;
        private UserService _service;
        public frmChangePassword(string username, string defaultTablespace,
            string temporaryTablespace)
        {
            InitializeComponent();
            _username = username;

            txtUsername.Text = username;
            cboDefaultTablespace.Text = defaultTablespace;
            cboTemporaryTablespace.Text = temporaryTablespace;

            numQuota.Minimum = 0;
            numQuota.Maximum = 999999;

            string connectionString =
                "User Id=SYS;Password=123;Data Source=localhost:1521/FREEPDB1;DBA Privilege=SYSDBA";

            var repo = new UserRepository(connectionString);
            _service = new UserService(repo);
            LoadComboboxData(defaultTablespace, temporaryTablespace);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _service.UpdateUserAccount(
                     txtUsername.Text,
                     txtPassword.Text,
                     cboDefaultTablespace.Text,
                     cboTemporaryTablespace.Text,
                     (int)numQuota.Value,
                     txtFullname.Text.Trim(),
                     txtEmail.Text.Trim());

                MessageBox.Show("Cập nhật User thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void LoadComboboxData(string defaultTablespace,string temporaryTablespace)
        {
            try
            {
                cboDefaultTablespace.Items.Clear();
                cboTemporaryTablespace.Items.Clear();

                var tablespaces = _service.GetTablespaces();
                var tempTablespaces = _service.GetTemporaryTablespaces();

                foreach (var item in tablespaces)
                    cboDefaultTablespace.Items.Add(item);

                foreach (var item in tempTablespaces)
                    cboTemporaryTablespace.Items.Add(item);

                cboDefaultTablespace.Text = defaultTablespace;
                cboTemporaryTablespace.Text = temporaryTablespace;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
