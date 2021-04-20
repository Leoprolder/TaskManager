using System.Data.Entity;

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