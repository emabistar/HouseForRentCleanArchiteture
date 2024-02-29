using System;
using DomainHouse.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationHouse.Dtos
{
	public class ModelViewHouseDtos
	{
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Type { get; set; }
        public string? Price { get; set; }
        public string? Location { get; set; }
        public string? Size { get; set; }
        public int? NOfBed { get; set; }
        public int? NOfBath { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("ModeId")]
        public int? ModeId { get; set; }

        public Mode? Mode { get; set; }
    }
}

