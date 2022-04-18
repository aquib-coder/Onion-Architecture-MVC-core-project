using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ATS.Models
{
    public class tbl_students:BaseEntity
    {
        public string Name { get; set; }  
        public string Fname { get; set; } 
        public string Email { get; set; } 
        public string Mobile { get; set; }
        public int DepID { get; set; }
        public string Description { get; set; } 
        public string Department { get; set; }  
        public virtual tbl_Department tbl_Department { get; set; }
    }
}
