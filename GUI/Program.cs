using System;
using System.Windows.Forms;
using GUI.Views;
using GUI.Presenters;
using BLL.Services.Implementations;
using DAL.Repositories.Implementations;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Khởi tạo tầng thấp nhất trước (DAL)
            var authRepo = new AuthRepo();

            // 2. Khởi tạo tầng BLL và tiêm DAL vào
            var authService = new AuthService(authRepo);

            // 3. Khởi tạo giao diện (View)
            var loginView = new frmLogin();

            // 4. Khởi tạo Presenter và tiêm View cùng BLL vào
            var loginPresenter = new LoginPresenter(loginView, authService);

            // 5. Gắn Presenter ngược lại cho View
            loginView.SetPresenter(loginPresenter);

            // 6. Chạy ứng dụng với View đã được setup hoàn chỉnh
            Application.Run(loginView);
        }
    }
}