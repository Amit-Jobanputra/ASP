using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_Qtwo_AmitJ.Controllers
{
    public class Student_AJController : Controller
    {
        // GET: Student_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        public string TestOne()
        {
            return "<h2>This Is Test</h2>";
        }
    }
}