using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_QSix_AmitJ.Controllers
{
    public class Department_AJController : Controller
    {
        // GET: Department_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Department()
        {
            return View();
        }
        public string DepartmentOne()
        {
            return "<mark>This Is Department</mark>";
        }
    }
}