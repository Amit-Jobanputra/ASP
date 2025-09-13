using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StdName { get; set; }
        public int StdAge { get; set; }
        public string Program { get; set; }
        public string StdGender { get; set; }

        public List<SelectListItem> ProgramList { get; set; }
        public List<SelectListItem> Gender { get; set; }
    }
}