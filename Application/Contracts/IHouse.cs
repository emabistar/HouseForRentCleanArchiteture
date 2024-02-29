using System;
using ApplicationHouse.Dtos;
using DomainHouse.Entities;

namespace ApplicationHouse.Contracts
{
	public interface IHouse
	{
        //Task<List<House>> GetAllHouseAsync();
        Task<List<ModelViewHouseDtos>> GetAllHouseAsync();
        Task<House> GetHouseByIdAsync(int Id);
        Task<HouseResponse> CreateHouseAsync(House house);
        Task<HouseResponse> UpdateHouseAsync(House house);
        Task<HouseResponse> DeleteHouseAsync(int id);

    }
}

