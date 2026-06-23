using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface ICreateUserView
    {
        string Username { get; }
        string Password { get; }
        string Profile { get; }
        string DefaultTablespace { get; }
        event EventHandler CreateClicked;
        void ShowMessage(string message);
        void CloseForm();
    }
}
