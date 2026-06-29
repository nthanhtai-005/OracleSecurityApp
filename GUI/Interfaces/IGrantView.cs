using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface IGrantView
    {
        // ===== DỮ LIỆU NGƯỜI DÙNG CHỌN =====
        string SelectedGrantee { get; }          // User/Role được cấp quyền
        string SelectedPrivilege { get; }        // Quyền được chọn
        string SelectedRole { get; }             // Role được chọn
        string SelectedTable { get; }            // Table được chọn
        string SelectedTableOwner { get; }       // Owner của table được chọn
        string SelectedColumn { get; }           // Column được chọn
        bool WithAdminOption { get; }            // Checkbox WITH ADMIN OPTION
        bool WithGrantOption { get; }            // Checkbox WITH GRANT OPTION

        // ===== SỰ KIỆN =====
        event EventHandler LoadDataRequested;
        event EventHandler GrantSystemPrivilegeClicked;
        event EventHandler RevokeSystemPrivilegeClicked;
        event EventHandler GrantObjectPrivilegeOnTableClicked;
        event EventHandler RevokeObjectPrivilegeOnTableClicked;
        event EventHandler GrantObjectPrivilegeOnColumnClicked;
        event EventHandler RevokeObjectPrivilegeOnColumnClicked;
        event EventHandler GrantRoleClicked;
        event EventHandler RevokeRoleClicked;
        event EventHandler TableSelectionChanged;
        event EventHandler GranteeTypeChanged;   // Khi chuyển giữa User/Role

        // ===== HIỂN THỊ DỮ LIỆU =====
        void LoadGrantees(DataTable users, DataTable roles);
        void LoadSystemPrivileges();
        void LoadRoles(DataTable roles);
        void LoadTables(DataTable tables);
        void LoadColumns(DataTable columns);
        void DisplaySystemPrivileges(DataTable data);
        void DisplayObjectPrivileges(DataTable data);
        void DisplayRoleGrants(DataTable data);

        // ===== THÔNG BÁO =====
        void ShowMessage(string message, bool isError = false);
    }
}
