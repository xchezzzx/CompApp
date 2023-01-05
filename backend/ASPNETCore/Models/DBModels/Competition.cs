using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class Competition
    {
        public int Id { get; set; }
        public string CompetitionName { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberConcTasks { get; set; }
        public string Hashtag { get; set; } = null!;
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public int UserCreateId { get; set; }
        public int UserUpdateId { get; set; }
        public int StatusId { get; set; }

        public virtual CompetitionStatus Status { get; set; } = null!;
        //public virtual User UserCreate { get; set; } = null!;
        //public virtual User UserUpdate { get; set; } = null!;
    }
}
