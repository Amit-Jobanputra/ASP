using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_QSeven_AmitJ.Controllers
{
    public class University_AJController : Controller
    {
        // GET: University_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Course()
        {
            return View();
        }
        public string CourseOne()
        {
            return "<code>This Is Course</code>";
        }
    }
}