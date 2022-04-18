using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATS.Models
{
    public class tbl_Department:BaseEntity
    {

        public string Department { get; set; } = "";
        public virtual tbl_students tbl_students { get; set; }
    }
}
