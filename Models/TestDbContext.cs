using Kolokwium_2.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Models
{
    public class TestDbContext : DbContext
    {
        public DbSet<Test> Test { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artist_Event> Artist_Events { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Event_Organiser> Event_Organisers { get; set; }
        public DbSet<Organiser> Organisers { get; set; }




        public TestDbContext() { }

        public TestDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TestEfConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistEfConfiguration());
            modelBuilder.ApplyConfiguration(new Artist_EventEfConfiguration());
            modelBuilder.ApplyConfiguration(new EventEfConfiguration());
            modelBuilder.ApplyConfiguration(new Event_OrganiserEfConfiguration());
            modelBuilder.ApplyConfiguration(new OrganiserEfConfiguration());

        }
    }
}

