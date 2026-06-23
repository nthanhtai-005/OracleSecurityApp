using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;
namespace GUI.Interfaces
{
    public interface IUserManagementView
    {
        void DisplayUsers(List<OracleUser> users);

        string SelectedUsername { get; }
        event EventHandler RefreshClicked;
        event EventHandler DeleteClicked;
        event EventHandler LockClicked;
        event EventHandler UnLockClicked;


    }
}
