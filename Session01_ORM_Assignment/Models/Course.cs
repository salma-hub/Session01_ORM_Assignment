using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM_Assignment.Models
{
    public class Course
    {
      
        public int ID { get; set; }
     //   [Required]
        public string Name { get; set; }
     //   [Required]
        public int Duration { get; set; }
        //   public string? Description { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; }
        public ICollection<Course_Inst> Course_Inst { get; set; }
    }
}
