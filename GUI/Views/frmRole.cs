using System;
using System.Data;
using System.Windows.Forms;
using GUI.Interfaces;
using GUI.Presenters;

namespace GUI.Views
{
    public partial class frmRole : Form, IRoleView
    {
        private RolePresenter _presenter;
        public frmRole()
        {
            InitializeComponent();
            _presenter = new RolePresenter(this);
        }

        public string RoleName => txtRoleName.Text.Trim();
        public bool IsPasswordChecked => chkHasPassword.Checked;
        public string Password => txtPassword.Text.Trim();

        public event EventHandler LoadRolesEvent;
        public event EventHandler CreateRoleEvent;
        public event EventHandler DropRoleEvent;
        public event EventHandler UpdateRolePasswordEvent;

        public void DisplayRoles(DataTable data)
        {
            dgvRoles.DataSource = data;
            // Tự động căn chỉnh cột cho đẹp
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ShowMessage(string message, bool isSuccess)
        {
            MessageBoxIcon icon = isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(message, isSuccess ? "Thông báo" : "Lỗi", MessageBoxButtons.OK, icon);
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            LoadRolesEvent?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateRoleEvent?.Invoke(this, EventArgs.Empty);

        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            DropRoleEvent?.Invoke(this, EventArgs.Empty);
        }

        private void chkHasPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = chkHasPassword.Checked;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdateRolePasswordEvent?.Invoke(this, EventArgs.Empty);
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ra cái dòng (Row) mà chuột vừa click vào
                DataGridViewRow row = dgvRoles.Rows[e.RowIndex];

                // 1. Lấy dữ liệu cột "ROLE" và đẩy lên ô Tên Role
                txtRoleName.Text = row.Cells["ROLE"].Value?.ToString();

                string passwordRequired = row.Cells["PASSWORD_REQUIRED"].Value?.ToString();

                if (passwordRequired == "YES")
                {
                    chkHasPassword.Checked = true;
                }
                else
                {
                    chkHasPassword.Checked = false;
                    txtPassword.Clear(); // Làm sạch ô nhập password
                }
            }
        }
    }
}
