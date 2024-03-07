using System;
using System.ComponentModel.DataAnnotations;

namespace DomainHouse.Entities
{
	public class Mode
	{
		public int Id { get; set; } 
        public  string? Name { get; set; }
        public List<House> Houses { get;} = new List<House>();
    }
}

