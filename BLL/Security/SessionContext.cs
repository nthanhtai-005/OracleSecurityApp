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

            DAL.Providers.OracleConnectionManager.CurrentConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OracleDefaultConn"].ConnectionString;
        }
    }
}