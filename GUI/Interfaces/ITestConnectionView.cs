using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface ITestConnectionView
    {
        string Username { get; }
        string Password { get; }

        void ShowMessage(string message, bool isError = false);

        event EventHandler TestButtonClicked;
    }
}
