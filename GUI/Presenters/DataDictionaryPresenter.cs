using System;
using GUI.Interfaces;
using BLL.Services.Interfaces;

namespace GUI.Presenters
{
    public class DataDictionaryPresenter
    {
        private readonly IDataDictionaryView _view;
        private readonly IDataDictionaryService _service;

        public DataDictionaryPresenter(IDataDictionaryView view, IDataDictionaryService service)
        {
            _view = view;
            _service = service;

            _view.LoadDataRequested += OnLoadDataRequested;
        }

        private void OnLoadDataRequested(object sender, EventArgs e)
        {
            try
            {
                _view.DisplayPrivileges(_service.GetPrivilegeTable());
                _view.DisplayRoles(_service.GetRoleTable());
                _view.DisplayProfiles(_service.GetProfileTable());
                _view.DisplayUsers(_service.GetUserTable());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi tải dữ liệu từ điển hệ thống: " + ex.Message, true);
            }
        }
    }
}