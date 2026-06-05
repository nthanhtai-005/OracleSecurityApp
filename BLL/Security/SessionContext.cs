using System;
using System.Collections.Generic;

namespace BLL.Security
{
    public static class SessionContext
    {
        // Lưu tên của người dùng đang đăng nhập có thể dùng để hiển thị
        public static string CurrentUsername { get; set; }

        // Lưu danh sách toàn bộ quyền hệ thống mà người này đang có
        // Khởi tạo sẵn một List rỗng để tránh lỗi NullReferenceException
        public static List<string> CurrentPrivileges { get; set; } = new List<string>();

        // Kiểm tra xem user có quyền cụ thể nào đó không
        public static bool HasPrivilege(string privilegeName)
        {
            if (CurrentPrivileges == null || CurrentPrivileges.Count == 0)
                return false;

            // Kiểm tra xem quyền có nằm trong danh sách không (ToUpper để không phân biệt hoa thường)
            return CurrentPrivileges.Contains(privilegeName.ToUpper());
        }

        // Hàm dọn dẹp: Gọi hàm này khi người dùng bấm nút "Đăng xuất" (Log out)
        public static void ClearSession()
        {
            CurrentUsername = null;
            CurrentPrivileges.Clear();
        }
    }
}