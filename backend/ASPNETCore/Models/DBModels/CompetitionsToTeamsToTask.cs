using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class CompetitionsToTeamsToTask
    {
        public int Id { get; set; }
        public int CompetitionId { get; set; }
        public int TeamId { get; set; }
        public int TaskId { get; set; }
        public TimeSpan TakeTime { get; set; }
        public TimeSpan SubmitTime { get; set; }
        public int TaskStateId { get; set; }
        public string? SolutionLink { get; set; }
        public string? Comment { get; set; }
        public string? FileLink { get; set; }
        public int? ApprovedPoints { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int StatusId { get; set; }

        public virtual Competition Competition { get; set; } = null!;
        public virtual User CreateUser { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual Exercise Task { get; set; } = null!;
        public virtual ExerciseState TaskState { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
        public virtual User UpdateUser { get; set; } = null!;
    }
}
