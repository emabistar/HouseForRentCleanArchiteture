using System;
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
    }
}

