using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Four_AmitJ.Controllers
{
    public class Q3Controller : Controller
    {
        // GET: Q3
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DyQ3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DyQ3(int fnumber, int snumber)
        {
            ViewBag.Fnum = fnumber;
            ViewBag.Snum = snumber;
            return View();
        }
    }
}