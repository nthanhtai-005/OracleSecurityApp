using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface IChangePasswordView
    {
        string Username { get; }

        string NewPassword { get; }

        event EventHandler SaveClicked;

        void ShowMessage(string message);

        void CloseForm();
    }
}
