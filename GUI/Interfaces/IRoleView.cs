using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface IRoleView
    {
        string RoleName { get; }
        bool IsPasswordChecked { get; }
        string Password { get; }

        event EventHandler CreateRoleEvent;
        event EventHandler DropRoleEvent;
        event EventHandler LoadRolesEvent;
        event EventHandler UpdateRolePasswordEvent;

        void ShowMessage(string message, bool isSuccess);
        void DisplayRoles(DataTable data);
    }
}
