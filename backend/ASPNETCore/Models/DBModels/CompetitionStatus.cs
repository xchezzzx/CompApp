using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class CompetitionStatus
    {
        public CompetitionStatus()
        {
            Competitions = new HashSet<Competition>();
        }

        public int Id { get; set; }
        public string CompetitionStatusName { get; set; } = null!;

        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
