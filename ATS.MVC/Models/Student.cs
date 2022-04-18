using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ATS.MVC.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage ="Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Required!!")]
        [Display(Name="First Name")]
        public string Fname { get; set; }

        [Required(ErrorMessage ="Enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter mobile number")]
        public string Mobile { get; set; }

        
        [Display(Name ="Department")]
        public int DepID { get; set; }

        public string Description { get; set; }
        
        
       public string Department { get; set; }
    }
}
