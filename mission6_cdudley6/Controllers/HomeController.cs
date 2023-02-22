using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission6_cdudley6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_cdudley6.Controllers
{
    public class HomeController : Controller
    {

        private DateApplicationContext blahContext { get; set; }

        //constructor

        public HomeController(DateApplicationContext someName)
        {
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confrimation", ar);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult WaitList ()
        {
            var applications = blahContext.responses.ToList();

            return View(applications);
        }

    }
}

      
