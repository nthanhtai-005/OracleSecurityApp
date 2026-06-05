using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface ILoginView
    {
        // Lấy dữ liệu người dùng nhập
        string Username { get; }
        string Password { get; }

        // Sự kiện khi bấm nút Đăng nhập
        event EventHandler LoginClicked;

        // Các hành động Form phải làm được
        void ShowMessage(string message, bool isError = false);
        void GoToMainForm(); // Lệnh chuyển màn hình
    }
}
