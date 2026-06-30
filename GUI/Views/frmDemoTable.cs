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
using GUI.Presenters;

namespace GUI.Views
{
    public partial class frmDemoTable : Form, IDemoTableView
    {
        private DemoTablePresenter _presenter;
        public frmDemoTable()
        {
            InitializeComponent();
            _presenter = new DemoTablePresenter(this);
        }
        public string Username => txtUsername.Text.Trim();
        public string Fullname => txtFullname.Text.Trim();
        public string Email => txtEmail.Text.Trim();

        // 2. Khai báo các sự kiện (Events)
        public event EventHandler LoadFormEvent;
        public event EventHandler AddEmployeeEvent;
        public event EventHandler UpdateEmployeeEvent;
        public event EventHandler DeleteEmployeeEvent;

        public void SetButtonSuaState(bool visible)
        {
            btnUpdate.Visible = visible;
        }

        public void SetButtonXoaState(bool visible)
        {
            btnDelete.Visible = visible;
        }

        public void ClearInputFields()
        {
            txtUsername.Clear();
            txtFullname.Clear();
            txtEmail.Clear();
            txtUsername.Enabled = true; 
            txtUsername.Focus();
        }
        public void SetButtonThemState(bool visible)
        {
            btnInsert.Visible = visible;
        }

        public void SetGridState(bool visible)
        {
            dgvData.Visible = visible;
        }

        public void DisplayData(DataTable dt)
        {
            dgvData.DataSource = dt;
        }

        public void ShowMessage(string msg, bool isSuccess)
        {
            MessageBox.Show(msg, isSuccess ? "Thành công" : "Lỗi phân quyền", MessageBoxButtons.OK, isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }
        private void frmDemoTable_Load(object sender, EventArgs e)
        {
            LoadFormEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddEmployeeEvent?.Invoke(this, EventArgs.Empty);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployeeEvent?.Invoke(this, EventArgs.Empty);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                // Gán dữ liệu từ lưới lên các Textbox
                txtUsername.Text = row.Cells["USERNAME"].Value?.ToString();
                txtFullname.Text = row.Cells["FULLNAME"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value?.ToString();

                // Khóa ô Username lại để không cho sửa khóa chính
                txtUsername.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployeeEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
