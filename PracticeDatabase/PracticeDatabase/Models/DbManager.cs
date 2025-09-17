using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace PracticeDatabase.Models
{
    public class DbManager:DbContext
    {
        public DbManager():base("Practice") {
            Database.SetInitializer<DbManager>(null);
        }
        public DbSet<Emp_detail> Emp_detail { get; set; }
    }
}