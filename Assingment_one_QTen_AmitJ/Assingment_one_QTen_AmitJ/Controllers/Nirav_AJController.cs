using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_QTen_AmitJ.Controllers
{
    public class Nirav_AJController : Controller
    {
        // GET: Nirav_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ASP()
        {
            return View();
        }
        public string ASPOne()
        {
            return "<strong>This Is APS Subject</strong>";
        }
    }
}