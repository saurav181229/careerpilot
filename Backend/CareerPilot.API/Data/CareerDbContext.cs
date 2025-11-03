using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerPilot.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CareerPilot.API.Data
{
    public class CareerDbContext : DbContext
    {

        public CareerDbContext(DbContextOptions<CareerDbContext> options) : base(options) { }

        public DbSet<Users> users => Set<Users>();
        public DbSet<Resume> Resumes => Set<Resume>();
        public DbSet<Jobs> Jobs => Set<Jobs>();

    }
    

    
  
}