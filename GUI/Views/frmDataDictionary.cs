using System;
using System.Data;
using System.Windows.Forms;
using GUI.Interfaces;
using GUI.Presenters;
using BLL.Services.Interfaces;
using BLL.Services.Implementations;

namespace GUI.Views
{
    public partial class frmDataDictionary : Form, IDataDictionaryView
    {
        private readonly DataDictionaryPresenter _presenter;

        public frmDataDictionary()
        {
            InitializeComponent();
            IDataDictionaryService service = new DataDictionaryService();
            _presenter = new DataDictionaryPresenter(this, service);
        }

        public event EventHandler LoadDataRequested;

        private void frmDataDictionary_Load(object sender, EventArgs e)
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
        }

        public void DisplayPrivileges(DataTable data)
        {
            dgvPrivileges.DataSource = data;
            dgvPrivileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisplayRoles(DataTable data)
        {
            dgvRoles.DataSource = data;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisplayProfiles(DataTable data)
        {
            dgvProfiles.DataSource = data;
            dgvProfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisplayUsers(DataTable data)
        {
            dgvUsers.DataSource = data;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ShowMessage(string message, bool isError)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(message, isError ? "Lỗi phân quyền" : "Thông báo", MessageBoxButtons.OK, icon);
        }

        private void frmDataDictionary_Load_1(object sender, EventArgs e)
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}