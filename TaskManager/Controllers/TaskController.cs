using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        TaskContext db = new TaskContext();

        public ActionResult Index()
        {
            return View("TaskView");
        }

        public ActionResult Create()
        {
            return View("TaskView");
        }

        public ActionResult Edit()
        {
            return View("TaskView");
        }

        public ActionResult Copy()
        {
            return View("TaskView");
        }

        public ActionResult Delete()
        {
            return View("TaskView");
        }
    }
}