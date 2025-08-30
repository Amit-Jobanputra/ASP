using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_Three_AmitJ.Controllers
{
    public class OddController : Controller
    {
        // GET: Odd
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