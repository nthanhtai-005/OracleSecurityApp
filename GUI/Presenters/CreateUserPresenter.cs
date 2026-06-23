using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Interface;
using GUI.Interfaces;
using MODELS;

namespace GUI.Presenters
{
    public class CreateUserPresenter
    {
        private readonly ICreateUserView _view;
        private readonly IUserService _service;

        public CreateUserPresenter(
            ICreateUserView view,
            IUserService service)
        {
            _view = view;
            _service = service;

            _view.CreateClicked += OnCreateClicked;
        }

        private void OnCreateClicked(
            object? sender,
            EventArgs e)
        {
            try
            {
                CreateUserRequest request =
                    new CreateUserRequest
                    {
                        Username = _view.Username,
                        Password = _view.Password,
                        Profile = _view.Profile,
                        DefaultTablespace =
                            _view.DefaultTablespace
                    };

                _service.CreateUser(request);

                _view.ShowMessage(
                    "Tạo User thành công!");

                _view.CloseForm();
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message);
            }
        }
    }
}
