using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Three_AJ.Controllers
{
    public class Q4Controller : Controller
    {
        // GET: Q4
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Odd()
        {
            ViewBag.num = 501;
            return View();
        }
    }
}