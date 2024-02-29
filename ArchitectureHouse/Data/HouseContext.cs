using System;
using System.Reflection.Metadata;
using DomainHouse.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureHouse.Data
{
	public class HouseContext :DbContext
	{
		public HouseContext(DbContextOptions<HouseContext>options):base(options)
		{
		}
		public DbSet<House> Houses { get; set;}
        public DbSet<Mode> Modes { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mode>()
                .HasMany(e => e.Houses)
                .WithOne(e => e.Mode)
                .HasForeignKey("ModeId")
                .IsRequired();
        }
          */
    }
   
}

