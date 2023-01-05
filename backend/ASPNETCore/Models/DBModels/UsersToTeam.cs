using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class UsersToTeam
    {
        public int UserId { get; set; }
        public int TeamId { get; set; }
        public bool IsCaptain { get; set; }

        public virtual Team Team { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
