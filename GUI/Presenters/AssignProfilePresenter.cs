using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Interface;
using GUI.Interfaces;

namespace GUI.Presenters
{
    public class AssignProfilePresenter
    {
        private readonly IAssignProfileView _view;
        private readonly IUserService _service;

        public AssignProfilePresenter(
            IAssignProfileView view,
            IUserService service)
        {
            _view = view;
            _service = service;

            LoadProfiles();

            _view.SaveClicked += OnSaveClicked;
        }

        private void LoadProfiles()
        {
            var profiles =
                _service.GetProfiles();

            _view.LoadProfiles(
                profiles);
        }

        private void OnSaveClicked(
    object? sender,
    EventArgs e)
        {
            try
            {
                _service.AssignProfile(
                    _view.Username,
                    _view.SelectedProfile);

                _view.ShowMessage("Gán Profile thành công");
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }
    }
}
