using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services.Implementations;
using BLL.Services.Interfaces;
using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;
using GUI.Interfaces;
using GUI.Presenters;

namespace GUI.Views
{
    public partial class frmGrant : Form, IGrantView
    {
        private GrantPresenter _presenter;

        private readonly string[] _systemPrivileges = {
            "CREATE PROFILE", "ALTER PROFILE", "DROP PROFILE",
            "CREATE ROLE", "ALTER ANY ROLE", "DROP ANY ROLE", "GRANT ANY ROLE",
            "CREATE SESSION",
            "CREATE ANY TABLE", "ALTER ANY TABLE", "DROP ANY TABLE",
            "SELECT ANY TABLE", "DELETE ANY TABLE", "INSERT ANY TABLE", "UPDATE ANY TABLE",
            "CREATE TABLE",
            "CREATE USER", "ALTER USER", "DROP USER"
        };

        private readonly string[] _objectPrivileges = {
            "SELECT", "INSERT", "DELETE"
        };

        public frmGrant()
        {
            InitializeComponent();
            IPrivilegeRepo privilegeRepo = new PrivilegeRepo();
            IPrivilegeService privilegeService = new PrivilegeService(privilegeRepo);
            _presenter = new GrantPresenter(this, privilegeService);
        }

        // ===== IMPLEMENT IGrantView =====
        public string SelectedGrantee => cboGrantee.SelectedItem?.ToString() ?? "";
        public string SelectedPrivilege => cboPrivilege.SelectedItem?.ToString()
                                        ?? cboObjectPrivilege.SelectedItem?.ToString() ?? "";
        public string SelectedRole => cboRole.SelectedItem?.ToString() ?? "";
        public string SelectedTable
        {
            get
            {
                if (cboTable.SelectedItem == null) return "";
                string[] parts = cboTable.SelectedItem.ToString().Split('.');
                return parts.Length > 1 ? parts[1] : parts[0];
            }
        }
        public string SelectedTableOwner
        {
            get
            {
                if (cboTable.SelectedItem == null) return "";
                string[] parts = cboTable.SelectedItem.ToString().Split('.');
                return parts.Length > 1 ? parts[0] : "";
            }
        }
        public string SelectedColumn => cboColumn.SelectedItem?.ToString() ?? "";
        public bool WithAdminOption => chkAdminOption.Checked || chkRoleAdminOption.Checked;
        public bool WithGrantOption => chkGrantOption.Checked;

        // ===== SỰ KIỆN =====
        public event EventHandler LoadDataRequested;
        public event EventHandler GrantSystemPrivilegeClicked;
        public event EventHandler RevokeSystemPrivilegeClicked;
        public event EventHandler GrantObjectPrivilegeOnTableClicked;
        public event EventHandler RevokeObjectPrivilegeOnTableClicked;
        public event EventHandler GrantObjectPrivilegeOnColumnClicked;
        public event EventHandler RevokeObjectPrivilegeOnColumnClicked;
        public event EventHandler GrantRoleClicked;
        public event EventHandler RevokeRoleClicked;
        public event EventHandler TableSelectionChanged;
        public event EventHandler GranteeTypeChanged;

        // ===== LOAD FORM =====
        private void frmGrant_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataRequested?.Invoke(this, EventArgs.Empty);

                // Chọn item đầu tiên mặc định
                if (cboGrantee.Items.Count > 0) cboGrantee.SelectedIndex = 0;
                if (cboPrivilege.Items.Count > 0) cboPrivilege.SelectedIndex = 0;
                if (cboGranteeObj.Items.Count > 0) cboGranteeObj.SelectedIndex = 0;
                if (cboObjectPrivilege.Items.Count > 0) cboObjectPrivilege.SelectedIndex = 0;
                if (cboTable.Items.Count > 0) cboTable.SelectedIndex = 0;
                if (cboGranteeRole.Items.Count > 0) cboGranteeRole.SelectedIndex = 0;
                if (cboRole.Items.Count > 0) cboRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== BUTTON EVENTS =====
        private void btnGrantSysPriv_Click(object sender, EventArgs e) => GrantSystemPrivilegeClicked?.Invoke(this, EventArgs.Empty);
        private void btnRevokeSysPriv_Click(object sender, EventArgs e) => RevokeSystemPrivilegeClicked?.Invoke(this, EventArgs.Empty);
        private void btnGrantObjTable_Click(object sender, EventArgs e) => GrantObjectPrivilegeOnTableClicked?.Invoke(this, EventArgs.Empty);
        private void btnRevokeObjTable_Click(object sender, EventArgs e) => RevokeObjectPrivilegeOnTableClicked?.Invoke(this, EventArgs.Empty);
        private void btnGrantObjColumn_Click(object sender, EventArgs e) => GrantObjectPrivilegeOnColumnClicked?.Invoke(this, EventArgs.Empty);
        private void btnRevokeObjColumn_Click(object sender, EventArgs e) => RevokeObjectPrivilegeOnColumnClicked?.Invoke(this, EventArgs.Empty);
        private void btnGrantRole_Click(object sender, EventArgs e) => GrantRoleClicked?.Invoke(this, EventArgs.Empty);
        private void btnRevokeRole_Click(object sender, EventArgs e) => RevokeRoleClicked?.Invoke(this, EventArgs.Empty);
        private void cboTable_SelectedIndexChanged(object sender, EventArgs e) => TableSelectionChanged?.Invoke(this, EventArgs.Empty);

        // ===== IMPLEMENT LOAD DỮ LIỆU =====
        public void LoadGrantees(DataTable users, DataTable roles)
        {
            cboGrantee.Items.Clear();
            cboGranteeObj.Items.Clear();
            cboGranteeRole.Items.Clear();

            foreach (DataRow row in users.Rows)
            {
                string name = row["USERNAME"].ToString();
                cboGrantee.Items.Add(name);
                cboGranteeObj.Items.Add(name);
                cboGranteeRole.Items.Add(name);
            }

            foreach (DataRow row in roles.Rows)
            {
                string name = row["ROLE"].ToString();
                cboGrantee.Items.Add(name);
                cboGranteeObj.Items.Add(name);
                cboGranteeRole.Items.Add(name);
            }
        }

        public void LoadSystemPrivileges()
        {
            cboPrivilege.Items.Clear();
            foreach (string priv in _systemPrivileges)
                cboPrivilege.Items.Add(priv);
        }

        public void LoadRoles(DataTable roles)
        {
            cboRole.Items.Clear();
            foreach (DataRow row in roles.Rows)
                cboRole.Items.Add(row["ROLE"].ToString());
        }

        public void LoadTables(DataTable tables)
        {
            cboTable.Items.Clear();
            foreach (DataRow row in tables.Rows)
                cboTable.Items.Add($"{row["OWNER"]}.{row["TABLE_NAME"]}");

            cboObjectPrivilege.Items.Clear();
            foreach (string priv in _objectPrivileges)
                cboObjectPrivilege.Items.Add(priv);
        }

        public void LoadColumns(DataTable columns)
        {
            cboColumn.Items.Clear();
            cboColumn.Items.Add("");
            foreach (DataRow row in columns.Rows)
                cboColumn.Items.Add(row["COLUMN_NAME"].ToString());
        }

        public void DisplaySystemPrivileges(DataTable data)
        {
            dgvSystemPrivileges.DataSource = data;
        }

        public void DisplayObjectPrivileges(DataTable data)
        {
            dgvObjectPrivileges.DataSource = data;
        }

        public void DisplayRoleGrants(DataTable data)
        {
            dgvRoleGrants.DataSource = data;
        }

        public void ShowMessage(string message, bool isError = false)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }
    }
}
