using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM_Assignment.Models
{
    public  class Student
    {
        public int ID { get; set; }
     //   [Required]
        public string FName { get; set; }
     //   [Required]
        public string LName { get; set; }
     //   [Required]
        public string Address { get; set; }
     //   [Range(18,33)]
        public int Age { get; set; }

        public int Dep_Id { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; }

    }
}
