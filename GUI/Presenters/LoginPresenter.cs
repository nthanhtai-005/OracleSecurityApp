using System;
using GUI.Interfaces;
using BLL.Services.Interfaces;
using BLL.Services.Implementations;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Implementations;

namespace GUI.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IAuthService _authService;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            IAuthRepo authRepo = new AuthRepo();
            _authService = new AuthService(authRepo);
            _view.LoginClicked += OnLoginClicked;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string user = _view.Username;
            string pass = _view.Password;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                _view.ShowMessage("Vui lòng nhập đầy đủ Username và Password!", true);
                return;
            }

            bool isSuccess = _authService.LoginAndLoadSession(user, pass);

            if (isSuccess)
            {
                _view.ShowMessage("Đăng nhập thành công!");
                _view.GoToMainForm(); // Ra lệnh cho Form Login tự đóng và mở Form Main lên
            }
            else
            {
                _view.ShowMessage("Sai tài khoản, mật khẩu hoặc User đang bị khóa!", true);
            }
        }
    }
}