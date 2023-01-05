using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TaskStatus
    {
        public TaskStatus()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string TaskStatusName { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
