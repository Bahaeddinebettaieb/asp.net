﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Consultation2
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Date consultation")]
        public DateTime date { get; set; }
        [Required]
        [Display(Name = "Patient")]
        public string patient { get; set; }
        [Display(Name = "Hospital name")]
        public int HospitalId { get; set; }
        [Display(Name = "Hospital name")]
        public virtual Hospital hospital { get; set; } 
        [Display(Name = "Doctor name")]
        public int DoctorId { get; set; }
        [Display(Name = "Doctor name")]
        public virtual Medecin doctor { get; set; }
    }
}
