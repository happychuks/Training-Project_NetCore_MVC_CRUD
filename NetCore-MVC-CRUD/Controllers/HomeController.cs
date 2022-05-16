using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore_MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Greeting = "Hi everyone, my name is Happy. I will be your tutor for today";
            ViewBag.Topic = "Today, we will be talking about .Net Core M-V-C Web Application";
            ViewBag.Close = "That will be all for now, thank you for your time. See you next time";
            ViewBag.ServerTime = DateTime.Now;
            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
