using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Interfaces;
using BLL.Services.Interface;

namespace GUI.Presenters
{
    public class UserManagementPresenter
    {
        private readonly IUserManagementView _view;

        private readonly IUserService _service;

        public UserManagementPresenter(
            IUserManagementView view,
            IUserService service)
        {
            _view = view;
            _service = service;
        }

        public void LoadUsers()
        {
            var users = _service.GetAllUsers();
            //MessageBox.Show($"Presenter: {users.Count}");
            _view.DisplayUsers(users);
            _view.DeleteClicked += OnDeleteClicked;
            _view.LockClicked += OnLockClicked;
            _view.UnLockClicked += OnUnLockClicked;
        }
        private void OnDeleteClicked(object? sender,EventArgs e)
        {
            try
            {
                string username =
                    _view.SelectedUsername;

                if (string.IsNullOrWhiteSpace(
                    username))
                    return;

                _service.DeleteUser(username);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnLockClicked(object? sender,EventArgs e)
        {
            try
            {
                string username =
                    _view.SelectedUsername;

                if (string.IsNullOrWhiteSpace(
                    username))
                    return;

                _service.LockUser(username);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnUnLockClicked(object? sender,EventArgs e)
        {
            try
            {
                string username =
                    _view.SelectedUsername;

                if (string.IsNullOrWhiteSpace(
                    username))
                    return;

                _service.UnLockUser(username);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
