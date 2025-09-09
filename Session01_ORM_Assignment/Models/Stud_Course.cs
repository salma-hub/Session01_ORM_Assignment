using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM_Assignment.Models
{
    public class Stud_Course
    {
        [Key]
        public int stud_ID { get; set; }
        public Student student { get; set; }
        public int Course_ID { get; set; }
        public Course Course { get; set; }
        public string Grade { get; set; }
    }

}
