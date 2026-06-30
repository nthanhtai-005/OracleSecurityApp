using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Interface;
using GUI.Interfaces;
using MODELS;
using DAL.Repositories.Implementations;
using DAL.Providers;
using BLL.Services.Implementations;

namespace GUI.Presenters
{
    public class CreateUserPresenter
    {
        private readonly ICreateUserView _view;
        private readonly IUserService _service;

        public CreateUserPresenter(
            ICreateUserView view)
        {
            _view = view;
            var repo = new UserRepository(
               OracleConnectionManager.CurrentConnectionString);

            _service = new UserService(repo);

            _view.CreateClicked += OnCreateClicked;
        }

        public List<string> GetTablespaces()
        {
            return _service.GetTablespaces();
        }

        public List<string> GetTemporaryTablespaces()
        {
            return _service.GetTemporaryTablespaces();
        }

        public List<string> GetProfiles()
        {
            return _service.GetProfiles();
        }

        private void OnCreateClicked(
            object? sender,
            EventArgs e)
        {
            try
            {
                CreateUserRequest request =new CreateUserRequest
             {
                 Username = _view.Username,
                 Password = _view.Password,
                 Profile = _view.Profile,
                 DefaultTablespace = _view.DefaultTablespace,
                 TemporaryTablespace = _view.TemporaryTablespace,
                 QuotaMB = _view.QuotaMB,
                  Fullname = _view.Fullname,
                 Email = _view.Email
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
