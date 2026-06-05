using GUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class frmTestConnection : Form, ITestConnectionView
    {
        public frmTestConnection()
        {
            InitializeComponent();
        }

        private void frmTestConnection_Load(object sender, EventArgs e)
        {

        }
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public event EventHandler TestButtonClicked;

        public void ShowMessage(string message, bool isError = false)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện để Presenter biết
            TestButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
