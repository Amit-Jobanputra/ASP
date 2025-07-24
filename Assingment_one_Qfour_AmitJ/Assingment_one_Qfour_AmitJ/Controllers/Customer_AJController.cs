using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_Qfour_AmitJ.Controllers
{
    public class Customer_AJController : Controller
    {
        // GET: Customer_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Order()
        {
            return View();
        }
        public string OrderOne()
        {
            return "<em><u>This Is Order</u></em>";
        }
    }
}