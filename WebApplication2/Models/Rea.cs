using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Rea
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Rea department")]
        public string rea { get; set; }
        [Display(Name = "Number of beds")]
        public int numberBed { get; set; }
        public int HospitalId { get; set; }
        [Display(Name = "Hospital name")]
        public virtual Hospital hospital { get; set; }
    }
}
