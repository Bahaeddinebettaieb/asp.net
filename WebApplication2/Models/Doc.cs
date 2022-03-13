using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Doc
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Doc name")]
        public string docName { get; set; }
        [Display(Name = "Speciality")]
        public string speciality { get; set; }
    }
}
