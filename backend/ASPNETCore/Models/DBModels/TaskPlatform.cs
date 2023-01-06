using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TaskPlatform
    {
        public TaskPlatform()
        {
            Tasks = new HashSet<CompTask>();
        }

        public int Id { get; set; }
        public string TaskPlatformName { get; set; } = null!;

        public virtual ICollection<CompTask> Tasks { get; set; }
    }
}
