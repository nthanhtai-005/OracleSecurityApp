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
    public class EditProfilePresenter
    {
        private readonly IEditProfileView _view;
        private readonly IUserService _service;

        public EditProfilePresenter(IEditProfileView view, IUserService service)
        {
            _view = view;
            _service = service;

            _view.CreateClicked += OnSaveClicked;
        }

        private void OnSaveClicked(object? sender, EventArgs e)
        {
            try
            {
                CreateProfileRequest request = new CreateProfileRequest
                {
                    ProfileName = _view.ProfileName,
                    FailedLoginAttempts = _view.FailedLoginAttempts,
                    PasswordLifeTime = _view.PasswordLifeTime,
                    PasswordLockTime = _view.PasswordLockTime,
                    PasswordGraceTime = _view.PasswordGraceTime,
                    SessionsPerUser = _view.SessionsPerUser,
                    ConnectTime = _view.ConnectTime,
                    IdleTime = _view.IdleTime
                };

                _service.UpdateProfile(request);

                _view.ShowMessage("Cập nhật Profile thành công!");
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message);
            }
        }
    }
}

