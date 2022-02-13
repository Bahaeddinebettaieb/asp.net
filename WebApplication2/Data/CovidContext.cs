using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class CovidContext : DbContext
    {
        public CovidContext (DbContextOptions<CovidContext> options)
            : base(options)
        {
        }


        public DbSet<WebApplication2.Models.Hospital> Hospital { get; set; }


        public DbSet<WebApplication2.Models.User> User { get; set; }
    }
}
