using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface IEditProfileView
    {
        string ProfileName { get; }

        int FailedLoginAttempts { get; }

        int PasswordLifeTime { get; }

        int PasswordLockTime { get; }

        int PasswordGraceTime { get; }

        int SessionsPerUser { get; }

        int ConnectTime { get; }

        int IdleTime { get; }

        event EventHandler? CreateClicked;

        void ShowMessage(string message);

        void CloseForm();
    }
}
