using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Consultation
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Date consultation")]
        public DateTime date { get; set; }

        [Display(Name = "Hospital name")]
        public int HospitalId { get; set; }
        [Display(Name = "Hospital name")]
        public virtual Hospital hospital { get; set; }
    }
}
