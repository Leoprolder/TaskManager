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


    }
}