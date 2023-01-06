using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class CompTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; } = null!;
        public string TaskContent { get; set; } = null!;
        public int TaskCategoryId { get; set; }
        public int TaskLangId { get; set; }
        public int TaskPlatformId { get; set; }
        public int Timeframe { get; set; }
        public int Points { get; set; }
        public bool? IfHasBonus { get; set; }
        public string? BonusContent { get; set; }
        public int? BonusTimeframe { get; set; }
        public int? BonusPoints { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public int UserCreateId { get; set; }
        public int UserUpdateId { get; set; }
        public int StatusId { get; set; }

        public virtual TaskStatus Status { get; set; } = null!;
        public virtual TaskCategory TaskCategory { get; set; } = null!;
        public virtual TaskLang TaskLang { get; set; } = null!;
        public virtual TaskPlatform TaskPlatform { get; set; } = null!;
        public virtual User UserCreate { get; set; } = null!;
        public virtual User UserUpdate { get; set; } = null!;
    }
}
