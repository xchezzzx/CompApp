using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TeamStatus
    {
        public TeamStatus()
        {
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Team> Teams { get; set; }
    }
}
