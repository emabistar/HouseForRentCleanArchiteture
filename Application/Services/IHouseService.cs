using System;
using ApplicationHouse.Dtos;
using DomainHouse.Entities;

namespace ApplicationHouse.Services
{
	public interface IHouseService
	{

        Task<List<House>> GetAllHouseAsync();
        Task<House> GetHouseByIdAsync(int id);
        Task<HouseResponse> CreateHouseAsync(House house);
        Task<HouseResponse> UpdateHouseAsync(House house);
        Task<HouseResponse> DeleteHouseAsync(int id);
    }
}

