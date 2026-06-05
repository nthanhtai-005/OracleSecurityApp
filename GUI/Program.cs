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

            // 1. Khởi tạo View
            var view = new frmTestConnection();

            // 2. Khởi tạo Presenter và truyền View vào
            var presenter = new TestConnectionPresenter(view);

            // 3. Chạy ứng dụng
            Application.Run(view);
        }
    }
}