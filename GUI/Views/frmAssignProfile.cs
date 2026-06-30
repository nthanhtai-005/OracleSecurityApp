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
using BLL.Services.Implementations;

namespace GUI.Views
{
    public partial class frmAssignProfile : Form, IAssignProfileView
    {
        private AssignProfilePresenter _presenter;
        private string _username;
        public frmAssignProfile(string username)
        {
            InitializeComponent();
            _username = username;
            txtUsername.Text = username;
            _presenter = new AssignProfilePresenter(this);
        }

        private void frmAssignProfile_Load(object sender, EventArgs e)
        {

        }
        public string Username
        {
            get => txtUsername.Text;
        }

        public string SelectedProfile
        {
            get => cboProfile.Text;
        }
        public event EventHandler? SaveClicked;
        public void LoadProfiles(
    List<string> profiles)
        {
            cboProfile.Items.Clear();

            foreach (var profile in profiles)
            {
                cboProfile.Items.Add(profile);
            }

            if (cboProfile.Items.Count > 0)
                cboProfile.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(
        this,
        EventArgs.Empty);
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
