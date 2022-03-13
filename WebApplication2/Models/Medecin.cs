using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Medecin
    {
        public int ID { get; set; }
        [Display(Name = "Medecin name")]
        public string medecinName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone number")]
        public string phone { get; set; }
        [Display(Name = "speciality")]
        public string speciality { get; set; }
        public virtual ICollection<Consultation2> Consultation2 { get; set; }
    }
}
