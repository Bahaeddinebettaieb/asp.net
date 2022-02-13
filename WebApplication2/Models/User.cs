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
        public string fullname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int location { get; set; }
        public int HospitalId { get; set; }
        public virtual Hospital hospital { get; set; }
    }
}
