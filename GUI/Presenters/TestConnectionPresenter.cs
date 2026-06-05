using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Interfaces;
using BLL.Services;

namespace GUI.Presenters
{
    public class TestConnectionPresenter
    {
        private readonly ITestConnectionView _view;
        private readonly TestConnectionService _service;

        public TestConnectionPresenter(ITestConnectionView view)
        {
            _view = view;
            _service = new TestConnectionService();

            // Gắn kết sự kiện
            _view.TestButtonClicked += OnTestButtonClicked;
        }

        private void OnTestButtonClicked(object sender, EventArgs e)
        {
            try
            {
                // Gọi Service ở BLL để xử lý
                _service.TestAndCreateUser(_view.Username, _view.Password);

                // Báo cáo thành công
                _view.ShowMessage($"Kết nối thành công! Đã tạo User '{_view.Username}' trong Oracle.");
            }
            catch (Exception ex)
            {
                // Báo lỗi (VD: sai pass Oracle, user đã tồn tại...)
                _view.ShowMessage($"Lỗi: {ex.Message}", true);
            }
        }
    }
}
