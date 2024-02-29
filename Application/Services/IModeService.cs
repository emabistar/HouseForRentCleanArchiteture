using System;
using ApplicationHouse.Contracts;
using ApplicationHouse.Dtos;
using DomainHouse.Entities;

namespace ApplicationHouse.Services
{
	public interface IModeService
	{
        public Task<ModeResponse> CreateModeAsync(Mode model);
        public Task<List<Mode>> GetAllAsync();
    }
}

