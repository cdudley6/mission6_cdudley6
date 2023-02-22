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
        private readonly ILogger<HomeController> _logger;
        private DateApplicationContext blahContext { get; set; }
        
        //constructor

        public HomeController(ILogger<HomeController> logger, DateApplicationContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult DatingApplication ()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
