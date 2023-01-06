using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TaskStatus
    {
        public TaskStatus()
        {
            Tasks = new HashSet<CompTask>();
        }

        public int Id { get; set; }
        public string TaskStatusName { get; set; } = null!;

        public virtual ICollection<CompTask> Tasks { get; set; }
    }
}
