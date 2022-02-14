using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Fullname")]
        public string fullname { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string phone { get; set; }
        [Required]
        [Display(Name = "Age")]
        public int age { get; set; }
        [Required]
        [Display(Name = "Location")]
        public string location { get; set; }
        [Display(Name = "Hospital name")]
        public int HospitalId { get; set; }
        public virtual Hospital hospital { get; set; }
    }
}
