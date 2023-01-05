using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Icon { get; set; }
        public string? Email { get; set; }
        public int? SumPoints { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public int UserCreateId { get; set; }
        public int UserUpdateId { get; set; }
        public int StatusId { get; set; }

        public virtual TeamStatus Status { get; set; } = null!;
        public virtual User UserCreate { get; set; } = null!;
        public virtual User UserUpdate { get; set; } = null!;
    }
}
