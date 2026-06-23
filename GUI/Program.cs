using System;
using System.Windows.Forms;
using GUI.Views;
using GUI.Presenters;

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmUserManagement());
        }
    }
}