using System.Web.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        TaskContext db = new TaskContext();

        public ActionResult Index()
        {
            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        public ActionResult Create(string description)
        {
            db.Tasks.Add(new Task(description));
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        public ActionResult Edit(Task task)
        {
            var storedTask = db.Tasks.Find(task.Id);
            storedTask = task;
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        public ActionResult Copy(Task task)
        {
            db.Tasks.Add(new Task(task.Description));
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        public ActionResult Delete(Task task)
        {
            db.Tasks.Remove(task);
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }
    }
}