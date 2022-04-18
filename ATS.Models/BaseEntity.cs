using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models
{
    public class BaseEntity
    {

        public int Id { get; set; } = 0;
        public DateTime CreatedDate { set; get; } = DateTime.Now;
        public DateTime ModifiedDate { set; get; } = DateTime.Now;
        public string CreatedBy { get; set; } = "";
        public string ModifiedBy { get; set; } = "";
        public string IPAddress { get; set; } = "";
        public bool IsDeleted { set; get; } = true;

    }
}
