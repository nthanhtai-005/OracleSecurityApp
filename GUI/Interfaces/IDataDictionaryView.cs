using System;
using System.Data;

namespace GUI.Interfaces
{
    public interface IDataDictionaryView
    {
        event EventHandler LoadDataRequested;

        void DisplayPrivileges(DataTable data);
        void DisplayRoles(DataTable data);
        void DisplayProfiles(DataTable data);
        void DisplayUsers(DataTable data);
        void ShowMessage(string message, bool isError);
    }
}