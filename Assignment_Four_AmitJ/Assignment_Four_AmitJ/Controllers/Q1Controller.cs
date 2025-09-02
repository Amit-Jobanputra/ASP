using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Four_AmitJ.Controllers
{
    public class Q1Controller : Controller
    {
        // GET: Q1
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DyQ1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DyQ1(string snumber , string enumber) {
            ViewBag.Snum = snumber;
            ViewBag.Enum = enumber;
            return View();
        }
    }
}