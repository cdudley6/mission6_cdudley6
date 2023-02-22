using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            ViewBag.Categorys = blahContext.Categorys.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else //if invalid
            {
                ViewBag.Categorys = blahContext.Categorys.ToList();

                return View();
            }

           
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WaitList ()
        {
            var applications = blahContext.responses
                .Include(x => x.Category)
                //.Where(x => x.Edited == false)
                .OrderBy(x =>x.Director)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Categorys = blahContext.Categorys.ToList();

            var application = blahContext.responses.Single(x => x.ApplicationId == applicationid);

            return View("DatingApplication", application);
        }
        [HttpPost]
        public IActionResult Edit (ApplicationResponse blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();

            return RedirectToAction("WaitList");
        }

        [HttpGet]
        public IActionResult Delete (int applicationid)
        {
            var application = blahContext.responses.Single(x => x.ApplicationId == applicationid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            blahContext.responses.Remove(ar);
            blahContext.SaveChanges();

            return RedirectToAction("WaitList");
        }
    }
}

      
