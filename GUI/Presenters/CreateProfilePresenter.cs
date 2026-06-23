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
    public class CreateProfilePresenter
    {
        private readonly ICreateProfileView _view;
        private readonly IUserService _service;

        public CreateProfilePresenter(ICreateProfileView view, IUserService service)
        {
            _view = view;
            _service = service;

            _view.CreateClicked += OnCreateClicked;
        }

        private void OnCreateClicked(object? sender, EventArgs e)
        {
            try
            {
                CreateProfileRequest request = new CreateProfileRequest
                {
                    ProfileName = _view.ProfileName.Trim().ToUpper(),

                    FailedLoginAttempts = _view.FailedLoginAttempts,

                    PasswordLifeTime = _view.PasswordLifeTime,

                    PasswordLockTime = _view.PasswordLockTime,

                    PasswordGraceTime = _view.PasswordGraceTime,

                    SessionsPerUser = _view.SessionsPerUser,

                    ConnectTime = _view.ConnectTime,

                    IdleTime = _view.IdleTime
                };

                if (string.IsNullOrWhiteSpace(request.ProfileName))
                {
                    _view.ShowMessage("Vui lòng nhập tên Profile");
                    return;
                }

                _service.CreateProfile(request);

                _view.ShowMessage("Tạo Profile thành công!");
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message);
            }
        }
    }
}
