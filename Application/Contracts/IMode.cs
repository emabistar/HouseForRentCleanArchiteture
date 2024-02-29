using System;
using ApplicationHouse.Dtos;
using DomainHouse.Entities;

namespace ApplicationHouse.Contracts
{
	public interface IMode
	{
		public Task<ModeResponse> CreateModeAsync(Mode model);
		public Task <List<Mode>> GetAllAsync();
        
    }
}

