using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Providers;
using DAL.Repositories.Implementations;
using GUI.Interfaces;
using GUI.Presenters;
using MODELS;
using BLL.Services.Implementations;


namespace GUI.Views
{
    public partial class frmUserManagement : Form, IUserManagementView
    {
        private UserManagementPresenter _presenter;
        public frmUserManagement(){
            InitializeComponent();
            string connectionString = "User Id=SYS;Password=123;Data Source=localhost:1521/FREEPDB1;DBA Privilege=SYSDBA";
            var repo = new UserRepository(connectionString);
            var service = new UserService(repo);
            _presenter =
                new UserManagementPresenter(
                    this,
                    service);
        }
        private void frmUserManagement_Load(object sender, EventArgs e){
            _presenter.LoadUsers();
        }
        public event EventHandler? RefreshClicked;
        private void btnRefresh_Click(object sender, EventArgs e){
            RefreshClicked?.Invoke(this,EventArgs.Empty);
        }
        public void DisplayUsers(List<OracleUser> users){
            //MessageBox.Show($"View: {users.Count}");
            dgvUsers.DataSource = users;
            //dgvUsers.DataSource = null;
          
            dgvUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void panel1_Paint(object sender, PaintEventArgs e){ }
        private void btnCreate_Click(object sender, EventArgs e){
            frmCreateUser frm = new frmCreateUser();
            frm.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e){
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler? LockClicked;
        private void btnLock_Click(object sender, EventArgs e){
            LockClicked?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler? UnLockClicked;
        private void btnUnLock_Click(object sender, EventArgs e){
            UnLockClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnEdit_Click(object sender, EventArgs e){
            frmChangePassword frm = new frmChangePassword(SelectedUsername);
            frm.ShowDialog();
        }
        private void btnAssignProfile_Click(object sender, EventArgs e){
            if (string.IsNullOrWhiteSpace(SelectedUsername)){
                MessageBox.Show("Vui lòng chọn User");
                return;
            }
            frmAssignProfile frm =new frmAssignProfile(SelectedUsername);
            frm.ShowDialog();
            _presenter.LoadUsers();
        }
        public string SelectedUsername{
            get
            {
                if (dgvUsers.CurrentRow == null)
                    return string.Empty;
                return dgvUsers.CurrentRow.Cells["Username"]
                                   .Value
                                   ?.ToString()
                       ?? string.Empty;
            }
        }
        public event EventHandler? DeleteClicked;
    }
}
