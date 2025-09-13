using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult Students()
        {
            var model = new Student
            {
                ProgramList = new List<SelectListItem>
                {
                    new SelectListItem{Value="1",Text="BCA"},
                    new SelectListItem{Value="2",Text="BBA"},
                    new SelectListItem{Value="3",Text="MCA"},
                    new SelectListItem{Value="4",Text="MBA"}
                },
                Gender = new List<SelectListItem>
                {
                    new SelectListItem{Value="1",Text="Male"},
                    new SelectListItem{Value="2",Text="Female"},
                    new SelectListItem{Value="3",Text="Other"}

                }
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Students(Student sdt)
        {
            sdt.ProgramList = new List<SelectListItem>
            {
                    new SelectListItem{Value="1",Text="BCA"},
                    new SelectListItem{Value="2",Text="BBA"},
                    new SelectListItem{Value="3",Text="MCA"},
                    new SelectListItem{Value="4",Text="MBA"}
            };
            sdt.Gender = new List<SelectListItem>
            {
                    new SelectListItem{Value="1",Text="Male"},
                    new SelectListItem{Value="2",Text="Female"},
                    new SelectListItem{Value="3",Text="Other"}

            };
            return View(sdt);
        }
    }
}