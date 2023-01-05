using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TaskPlatform
    {
        public TaskPlatform()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string TaskPlatformName { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
