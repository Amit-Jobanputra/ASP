using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_QEight_AmitJ.Controllers
{
    public class Python_AJController : Controller
    {
        // GET: Python_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ai()
        {
            return View();
        }
        public string AiOne()
        {
            return "<button>This Is AI</button>";
        }
    }
}