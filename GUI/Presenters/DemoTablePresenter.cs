using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Interfaces;
using BLL.Services;
using BLL.Services.Implementations;

namespace GUI.Presenters
{
    public class DemoTablePresenter
    {
        private readonly IDemoTableView _view;
        private readonly DemoTableService _service;

        public DemoTablePresenter(IDemoTableView view)
        {
            _view = view;
            _service = new DemoTableService();

            _view.LoadFormEvent += OnLoadForm;
            _view.AddEmployeeEvent += OnAddEmployee;
            _view.UpdateEmployeeEvent += OnUpdateEmployee; // Mới
            _view.DeleteEmployeeEvent += OnDeleteEmployee; // M
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            var privileges = _service.CheckAccess();

            _view.SetButtonThemState(privileges["INSERT"]);
            _view.SetButtonSuaState(privileges.ContainsKey("UPDATE") && privileges["UPDATE"]);
            _view.SetButtonXoaState(privileges.ContainsKey("DELETE") && privileges["DELETE"]);
            _view.SetGridState(privileges["SELECT"]);

            if (privileges["SELECT"])
            {
                try
                {
                    var dt = _service.LoadData();
                    _view.DisplayData(dt);
                }
                catch (Exception ex)
                {
                    _view.ShowMessage("Lỗi tải dữ liệu bảng: " + ex.Message, false);
                }
            }
            else
            {
                _view.ShowMessage("Truy cập bị từ chối: Tài khoản của bạn không có quyền SELECT trên bảng NHANVIEN", false);
            }
        }

        private void OnAddEmployee(object sender, EventArgs e)
        {
            try
            {
                _service.AddNewEmployee(_view.Username, _view.Fullname, _view.Email);
                _view.ShowMessage("Thêm người dùng mới vào hệ thống thành công!", true);

                _view.DisplayData(_service.LoadData());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Thực thi thất bại: " + ex.Message, false);
            }
        }

        private void OnUpdateEmployee(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_view.Username))
                {
                    _view.ShowMessage("Vui lòng chọn một nhân viên để sửa!", false);
                    return;
                }

                // Giả định service của bạn có hàm UpdateEmployee
                _service.UpdateEmployee(_view.Username, _view.Fullname, _view.Email);
                _view.ShowMessage("Cập nhật thông tin thành công!", true);

                _view.DisplayData(_service.LoadData());
                _view.ClearInputFields();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Cập nhật thất bại: " + ex.Message, false);
            }
        }

        private void OnDeleteEmployee(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_view.Username))
                {
                    _view.ShowMessage("Vui lòng chọn một nhân viên để xóa!", false);
                    return;
                }

                // Giả định service của bạn có hàm DeleteEmployee
                _service.DeleteEmployee(_view.Username);
                _view.ShowMessage("Xóa nhân viên thành công!", true);

                _view.DisplayData(_service.LoadData());
                _view.ClearInputFields();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Xóa thất bại: " + ex.Message, false);
            }
        }
    }
}
