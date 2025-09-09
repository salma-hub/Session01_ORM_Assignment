using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM_Assignment.Models
{
    public class Departement
    {
        public int ID { get; set; }
     //   [Required]
        public string Name { get; set; }

        public int Ins_ID { get; set; }
    }
}
