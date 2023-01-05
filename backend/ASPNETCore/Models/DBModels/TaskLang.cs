using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TaskLang
    {
        public TaskLang()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string TaskLang1 { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
