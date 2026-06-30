using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface ICreateProfileView
    {
        string ProfileName { get; }

        string FailedLoginAttempts { get; }
        string PasswordLifeTime { get; }
        string PasswordLockTime { get; }
        string PasswordGraceTime { get; }
        string SessionsPerUser { get; }
        string ConnectTime { get; }
        string IdleTime { get; }

        event EventHandler? CreateClicked;

        void ShowMessage(string message);
        void CloseForm();
    }
}
