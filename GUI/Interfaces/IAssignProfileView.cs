using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface IAssignProfileView
    {
        string Username { get; }

        string SelectedProfile { get; }

        void LoadProfiles(
            List<string> profiles);

        event EventHandler SaveClicked;
        void ShowMessage(string message);
        void CloseForm();
    }
}
