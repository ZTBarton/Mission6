using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TaskContext _taskContext { get; set; }

        public HomeController(ILogger<HomeController> logger, TaskContext taskCtx)
        {
            _logger = logger;
            _taskContext = taskCtx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _taskContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddTask(TaskResponse model)
        {
            if (ModelState.IsValid)
            {
                _taskContext.Add(model);
                _taskContext.SaveChanges();
                return RedirectToAction("Quadrants");
            }
            else
            {
                ViewBag.Categories = _taskContext.Categories.ToList();

                return View("AddTask", model);
            }
        }

        public IActionResult EditTask()
        {
            return View();
        }
        public IActionResult Quadrants()
        {
            var tasks = _taskContext.Tasks
                .Include(x => x.Category)
                .ToList();

            return View("Quandrants", tasks);
        }
    }
}

