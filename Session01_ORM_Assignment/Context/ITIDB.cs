using Microsoft.EntityFrameworkCore;
using Session01_ORM_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM_Assignment.Context
{
    public class ITIDB:DbContext
    {
        public ITIDB() : base()
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=.;database=ITIBD;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        public DbSet <Student> Students { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Topic> Topic { get; set; }
       public DbSet<Stud_Course> Stud_Course { get; set; }
      public DbSet<Course_Inst> Course_Inst { get; set; }
    }
}
