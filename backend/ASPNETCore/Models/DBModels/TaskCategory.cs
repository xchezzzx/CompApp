using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.DBModels
{
    public partial class TaskCategory
    {
        public TaskCategory()
        {
            Tasks = new HashSet<CompTask>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<CompTask> Tasks { get; set; }
    }
}
