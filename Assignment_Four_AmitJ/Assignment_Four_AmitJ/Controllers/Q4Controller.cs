using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Four_AmitJ.Controllers
{
    public class Q4Controller : Controller
    {
        // GET: Q4
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DyQ4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DyQ4(int number)
        {
            ViewBag.number = number;

            return View();
        }
    }
}