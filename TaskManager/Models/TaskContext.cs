using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskManager.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext() : base("TaskContext")
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}