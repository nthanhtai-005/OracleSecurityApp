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
using GUI.Interfaces;
using GUI.Presenters;

namespace GUI.Views
{
    public partial class frmProfileManagement : Form
    {
        private UserService _service;

        public frmProfileManagement()
        {
            InitializeComponent();

            string connectionString =
                "User Id=SYS;Password=123;Data Source=localhost:1521/FREEPDB1;DBA Privilege=SYSDBA";

            var repo = new UserRepository(connectionString);
            _service = new UserService(repo);
        }

        private void frmProfileManagement_Load(object sender, EventArgs e)
        {
            LoadProfiles();
        }

        private void LoadProfiles(string keyword = "")
        {
            try
            {
                var profiles = _service.GetProfileSummaries(keyword);

                dgvProfiles.DataSource = null;
                dgvProfiles.DataSource = profiles;
                dgvProfiles.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvProfiles.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetSelectedProfileName()
        {
            if (dgvProfiles.CurrentRow == null)
                return string.Empty;

            return dgvProfiles.CurrentRow.Cells["ProfileName"]
                .Value?.ToString() ?? "";
        }

        private int ConvertLimitToInt(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return 1;

            if (value == "DEFAULT" || value == "UNLIMITED")
                return 1;

            if (int.TryParse(value, out int result))
                return result;

            return 1;
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            frmCreateProfile frm = new frmCreateProfile();
            frm.ShowDialog();

            LoadProfiles();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (dgvProfiles.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn Profile cần sửa");
                return;
            }

            CreateProfileRequest request = new CreateProfileRequest
            {
                ProfileName = GetSelectedProfileName(),

                FailedLoginAttempts =
                    ConvertLimitToInt(dgvProfiles.CurrentRow.Cells["FailedLoginAttempts"].Value?.ToString()),

                PasswordLifeTime =
                    ConvertLimitToInt(dgvProfiles.CurrentRow.Cells["PasswordLifeTime"].Value?.ToString()),

                PasswordLockTime =
                    ConvertLimitToInt(dgvProfiles.CurrentRow.Cells["PasswordLockTime"].Value?.ToString()),

                PasswordGraceTime =
                    ConvertLimitToInt(dgvProfiles.CurrentRow.Cells["PasswordGraceTime"].Value?.ToString()),

                SessionsPerUser =
                    ConvertLimitToInt(dgvProfiles.CurrentRow.Cells["SessionsPerUser"].Value?.ToString()),

                ConnectTime =
                    ConvertLimitToInt(dgvProfiles.CurrentRow.Cells["ConnectTime"].Value?.ToString()),

                IdleTime =
                    ConvertLimitToInt(dgvProfiles.CurrentRow.Cells["IdleTime"].Value?.ToString())
            };

            frmEditProfile frm = new frmEditProfile(request);
            frm.ShowDialog();

            LoadProfiles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string profileName = GetSelectedProfileName();

                if (string.IsNullOrWhiteSpace(profileName))
                {
                    MessageBox.Show("Vui lòng chọn Profile cần xóa");
                    return;
                }

                if (profileName == "DEFAULT")
                {
                    MessageBox.Show("Không được xóa Profile DEFAULT");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa Profile {profileName} không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                _service.DeleteProfile(profileName);

                MessageBox.Show("Xóa Profile thành công");
                LoadProfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchProfile.Text = "";
            LoadProfiles();
        }

        private void SearchProfile()
        {
            string keyword = txtSearchProfile.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập tên Profile cần tìm");
                return;
            }

            var allProfiles = _service.GetProfilesDetail();

            var result = allProfiles
                .Where(p => p.ProfileName.ToUpper() == keyword)
                .ToList();

            if (result.Count == 0)
            {
                MessageBox.Show("Không tồn tại Profile này trong danh sách");
                dgvProfiles.DataSource = null;
                return;
            }

            dgvProfiles.DataSource = null;
            dgvProfiles.DataSource = result;

            dgvProfiles.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProfile();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}

