using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Doctor name")]
        public string doctorName { get; set; }
        [Display(Name = "registration number")]
        public string registrationNumber { get; set; }  
        [Display(Name = "specialite")]
        public string specialite { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
