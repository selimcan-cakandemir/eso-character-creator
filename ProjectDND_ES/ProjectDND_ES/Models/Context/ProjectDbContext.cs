using ProjectDND_ES.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectDND_ES.Models.Context
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-92AU4IL;Database=ProjectDND_ES;Trusted_Connection=True;";
        }

        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<CharacterRace> CharacterRaces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterClass>().HasKey(x => new { x.ClassId });
            modelBuilder.Entity<CharacterRace>().HasKey(x => new { x.RaceId });
            base.OnModelCreating(modelBuilder);
        }
    }


}