using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_Qthree_AmitJ.Controllers
{
    public class Orders_AJController : Controller
    {
        // GET: Orders_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult customer()
        {
            return View();
        }
        public string customerOne()
        {
            return "<i>This Is Customer</i>";
        }
    }
}