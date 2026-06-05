using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Interfaces;
using BLL.Services;

namespace GUI.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly AuthService _authService;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            _authService = new AuthService();

            // Gắn kết sự kiện lắng nghe nút bấm
            _view.LoginClicked += OnLoginClicked;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string user = _view.Username;
            string pass = _view.Password;

            // 1. Kiểm tra không được để trống
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                _view.ShowMessage("Vui lòng nhập đầy đủ Username và Password!", true);
                return;
            }

            // 2. Nhờ BLL kết nối thử xuống Oracle và nạp quyền vào Session
            bool isSuccess = _authService.LoginAndLoadSession(user, pass);

            // 3. Xử lý kết quả
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
