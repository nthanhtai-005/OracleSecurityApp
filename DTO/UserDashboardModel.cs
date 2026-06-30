using System;

namespace DTO
{
    public class UserDashboardModel
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CreatedDate { get; set; }

        public string AccountStatus { get; set; }
        public string LockDate { get; set; }
        public string Profile { get; set; }
        public string DefaultTablespace { get; set; }
        public string TemporaryTablespace { get; set; }
    }
}