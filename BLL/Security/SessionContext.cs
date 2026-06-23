using System;
using System.Collections.Generic;
using DAL.Providers; // Thêm dòng này

namespace BLL.Security
{
    public static class SessionContext
    {
        public static string CurrentUsername { get; set; }

        public static List<string> CurrentPrivileges { get; set; } = new List<string>();

        public static bool HasPrivilege(string privilegeName)
        {
            if (CurrentPrivileges == null || CurrentPrivileges.Count == 0)
                return false;

            return CurrentPrivileges.Contains(privilegeName.ToUpper());
        }

        public static void ClearSession()
        {
            CurrentUsername = null;
            CurrentPrivileges.Clear();

            // THÊM DÒNG NÀY: Trả lại quyền gác cổng cho ADMIN_BM sau khi User đăng xuất
            OracleConnectionManager.CurrentConnectionString = "Data Source=localhost:1521/DB_BAOMAT; User Id=ADMIN_BM; Password=Oracle_1234;";
        }
    }
}