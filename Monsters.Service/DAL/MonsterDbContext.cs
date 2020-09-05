using Microsoft.EntityFrameworkCore;
using Monsters.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Service.DAL
{
    public class MonsterDbContext : DbContext
    {
        
        public DbSet<Door> Doors { get; set; }
        public DbSet<Scare> Scares { get; set; }

        public MonsterDbContext()
        {

        }
        public MonsterDbContext(DbContextOptions<MonsterDbContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Monsters;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //seed data
            this.Seed(builder); 
        }

       
    }
}
