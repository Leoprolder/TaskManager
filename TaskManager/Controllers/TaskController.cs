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

        [HttpPost]
        public ActionResult Create(string description)
        {
            db.Tasks.Add(new Task(description));
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        [HttpPost]
        public ActionResult Edit(string taskId, string description)
        {
            var storedTask = db.Tasks.Find(taskId);
            storedTask.Description = description;
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        [HttpPost]
        public ActionResult Switch(string taskId)
        {
            var storedTask = db.Tasks.Find(taskId);
            storedTask.SwitchDoneCondition();
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        [HttpGet]
        public ActionResult Copy(string taskId)
        {
            var task = db.Tasks.Find(taskId);
            db.Tasks.Add(new Task(task.Description));
            db.SaveChanges();

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }

        [HttpGet]
        public ActionResult Delete(string taskId)
        {
            try
            {
                var task = db.Tasks.Find(taskId);
                db.Tasks.Remove(task);
                db.SaveChanges();
            }
            catch
            {
            }

            ViewBag.Tasks = db.Tasks;

            return View("TaskView");
        }
    }
}