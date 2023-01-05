using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class User
    {
        public User()
        {
            CompetitionUserCreates = new HashSet<Competition>();
            CompetitionUserUpdates = new HashSet<Competition>();
            InverseUserCreate = new HashSet<User>();
            InverseUserUpdate = new HashSet<User>();
            TaskUserCreates = new HashSet<Task>();
            TaskUserUpdates = new HashSet<Task>();
            TeamUserCreates = new HashSet<Team>();
            TeamUserUpdates = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public int? PointsSummary { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }
        public int UserCreateId { get; set; }
        public int UserUpdateId { get; set; }
        public int StatusId { get; set; }

        public virtual UserRole Role { get; set; } = null!;
        public virtual UserStatus Status { get; set; } = null!;
        public virtual User UserCreate { get; set; } = null!;
        public virtual User UserUpdate { get; set; } = null!;
        public virtual ICollection<Competition> CompetitionUserCreates { get; set; }
        public virtual ICollection<Competition> CompetitionUserUpdates { get; set; }
        public virtual ICollection<User> InverseUserCreate { get; set; }
        public virtual ICollection<User> InverseUserUpdate { get; set; }
        public virtual ICollection<Task> TaskUserCreates { get; set; }
        public virtual ICollection<Task> TaskUserUpdates { get; set; }
        public virtual ICollection<Team> TeamUserCreates { get; set; }
        public virtual ICollection<Team> TeamUserUpdates { get; set; }
    }
}
