using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Hospital
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Hospital name")]
        public string nameHospital { get; set; }
        [Display(Name = "City")]
        public string cityHospital { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<Rea> Rea { get; set; }
        public virtual ICollection<Consultation> Consultation { get; set; }
    }
}
