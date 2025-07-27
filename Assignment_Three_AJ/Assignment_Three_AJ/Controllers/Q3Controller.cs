using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Three_AJ.Controllers
{
    public class Q3Controller : Controller
    {
        // GET: Q3
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Arithmatic()
        {
            ViewBag.a = 10;
            ViewBag.b = 20;
            return View();
        }
    }
}