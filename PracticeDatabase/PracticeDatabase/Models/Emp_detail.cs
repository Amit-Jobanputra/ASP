using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
namespace PracticeDatabase.Models
{
    public class Emp_detail
    {   
        [Key]
        public long Empid { get; set; }
        public string Emp_Name { get; set; }
        public int  Experience { get; set; }
        public long Joining_Year { get; set; }
        public string Department { get; set; }
    }
}