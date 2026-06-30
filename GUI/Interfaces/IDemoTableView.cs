using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface IDemoTableView
    {
        string Username { get; }
        string Fullname { get; }
        string Email { get; }

        // Các hàm điều khiển Giao diện (UI)

        // 2. Các hàm cập nhật UI
        void SetButtonThemState(bool visible);
        void SetButtonSuaState(bool visible);
        void SetButtonXoaState(bool visible);
        void SetGridState(bool visible);
        void DisplayData(DataTable dt);
        void ShowMessage(string msg, bool isSuccess);
        void ClearInputFields(); 

        // Các sự kiện
        event EventHandler LoadFormEvent;
        event EventHandler AddEmployeeEvent;
        // Thêm vào IDemoTableView.cs
        event EventHandler UpdateEmployeeEvent;
        event EventHandler DeleteEmployeeEvent;
    }
}
