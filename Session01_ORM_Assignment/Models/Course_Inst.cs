using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM_Assignment.Models
{
    public  class Course_Inst
    {
        [Key]
        public int Inst_ID { get; set; }         
        public Instructor Instructor { get; set; }

        public int Course_ID { get; set; }       
        public Course Course { get; set; }
        public string evaluate { get; set; }
    }
}
