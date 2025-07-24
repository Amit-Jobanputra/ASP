using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assingment_one_QFive_AmitJ.Controllers
{
    public class Faculty_AJController : Controller
    {
        // GET: Faculty_AJ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Professor()
        {
            return View();
        }
        public string ProfessorOne()
        {
            return "<s>This Is Professor</s>";
        }
    }
}