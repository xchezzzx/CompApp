using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string UserStatusName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
