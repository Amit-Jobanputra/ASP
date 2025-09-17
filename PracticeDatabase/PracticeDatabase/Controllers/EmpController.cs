using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeDatabase.Models;

namespace PracticeDatabase.Controllers
{
    public class EmpController : Controller
    {
        DbManager db = new DbManager();
        // GET: Emp
        public ActionResult Index()
        {
            return View(db.Emp_detail.ToList());
        }
    }
}