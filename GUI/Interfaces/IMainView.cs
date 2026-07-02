using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Interfaces
{
    public interface IMainView
    {
        event EventHandler MainLoad;
        // THÊM MỚI 1: Các sự kiện báo cáo có người click nút
        event EventHandler OpenUserClicked;
        event EventHandler OpenRoleClicked;
        event EventHandler OpenProfileClicked;
        event EventHandler OpenGrantClicked;
        event EventHandler OpenDemoClicked;
        void SetUserMenuVisible(bool isVisible);
        void SetRoleMenuVisible(bool isVisible);
        void SetProfileMenuVisible(bool isVisible);
        void SetGrantMenuVisible(bool isVisible);
        void SetDataDictionaryMenuVisible(bool isVisible);

        // Nút DemoTable có thể luôn hiện, hoặc ẩn tùy logic nhóm
        void SetDemoTableMenuVisible(bool isVisible);
        // THÊM MỚI 2: Các lệnh yêu cầu Form mở cửa sổ
        void ShowUserForm();
        void ShowRoleForm();
        void ShowProfileForm();
        void ShowGrantForm();
        void ShowDemoForm();
        void DisplayUserDashboard(UserDashboardModel userInfo);

        // Hiển thị DataGridView
        void DisplayUserRoles(DataTable data);
        void DisplayUserSystemPrivileges(DataTable data);
        void DisplayUserObjectPrivileges(DataTable data);
        void DisplayUserQuotas(DataTable data);
        event EventHandler LogoutClicked;
        void RestartApplication();
        event EventHandler OpenDataDictionaryClicked;
        void ShowDataDictionaryForm();
    }
}
