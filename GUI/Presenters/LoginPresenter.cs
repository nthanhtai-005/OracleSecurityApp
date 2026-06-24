using System;
using GUI.Interfaces;
using BLL.Services.Interfaces;

namespace GUI.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IAuthService _authService;

        public LoginPresenter(ILoginView view, IAuthService authService)
        {
            _view = view;
            _authService = authService;
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
                _view.GoToMainForm();
            }
            else
            {
                _view.ShowMessage("Sai tài khoản, mật khẩu hoặc User đang bị khóa!", true);
            }
        }
    }
}