
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Three_AJ.Controllers
{
    public class Q2Controller : Controller
    {
        // GET: Q2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Table()
        {
            ViewBag.number = 20;
            return View();
        }
    }
}