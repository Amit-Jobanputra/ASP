using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Three_AJ.Controllers
{
    public class Q1Controller : Controller
    {
        // GET: Q1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrintNumber()
        {
            ViewBag.number = 20;
            return View();
        }
    }
}