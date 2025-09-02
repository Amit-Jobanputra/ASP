using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Four_AmitJ.Controllers
{
    public class Q2Controller : Controller
    {
        // GET: Q2
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DyQ2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DyQ2(int snumber)
        {
            ViewBag.Snum = snumber;
            
            return View();
        }
    }
}