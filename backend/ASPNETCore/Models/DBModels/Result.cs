using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class Result
    {
        public int CompetitionId { get; set; }
        public int TeamId { get; set; }
        public int UserId { get; set; }
        public decimal Points { get; set; }

        public virtual Competition Competition { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
