using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TaskCategory
    {
        public TaskCategory()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
