using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM_Assignment.Models
{
    public  class Instructor
    {
        public int ID { get; set; }
      //  [Required]
        public string Name { get; set; }
     //   [Required]
        public decimal Bouns { get; set; }
    //    [Required]
        public decimal Salary { get; set; }
     //   public string? Adress { get; set; }
        public string Adress { get; set; }
        //     [Requied]
        public decimal HourRate { get; set; }

        public int Dept_ID { get; set; }
        public ICollection<Course_Inst> Course_Inst { get; set; }


    }
}
