using System.Data.Entity;

namespace TaskManager.Models
{
    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            db.Tasks.Add(new Task("Get this project done", true));
            db.Tasks.Add(new Task("Watch MLP", false));
            db.Tasks.Add(new Task("Work it Make it Do it Makes us Harder Better Faster Stronger More than Hour Hour Never Ever After Work is Over Work it Make it Do it Makes us Harder Better Faster Stronger Work it harder, make it better Do it faster, makes us stronger More than ever, hour after hour Work is never over Work it harder, make it better Do it faster, makes us stronger More than ever, hour after hour Work is never over Work it harder, make it better Do it faster, makes us stronger More than ever, hour after hour Work is never over Work it harder, make it better Do it faster, makes us stronger More than ever, hour after hour Work is never over Work it harder, make it better Do it faster, makes us stronger More than ever, hour after hour Work is never over Work it harder, make it better Do it faster, makes us… ", true));

            base.Seed(db);
        }
    }
}