using ProjectElderScrolls.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectElderScrolls.Models
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-92AU4IL;Database=ProjectElderScrollsDB;Trusted_Connection=True;";
        }

        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<CharacterRace> CharacterRaces { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterClass>().HasKey(x => new { x.ClassId });
            modelBuilder.Entity<CharacterRace>().HasKey(x => new { x.RaceId });
            base.OnModelCreating(modelBuilder);
        }

    }
}