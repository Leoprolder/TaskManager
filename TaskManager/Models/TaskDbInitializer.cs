using System.Data.Entity;

namespace TaskManager.Models
{
    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            db.Tasks.Add(new Task("Get this project done", false));

            base.Seed(db);
        }
    }
}