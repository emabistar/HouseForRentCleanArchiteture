using ApplicationHouse.Contracts;
using ApplicationHouse.Dtos;
using ArchitectureHouse.Data;
using DomainHouse.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureHouse.Repositories
{
    public class HouseRepository:IHouse
	{
        private readonly HouseContext _context;
		public HouseRepository(HouseContext context)
		{
           _context = context;
		}

        public async Task<HouseResponse> CreateHouseAsync(House house)
        {
           var check = _context.Houses.FirstOrDefault(e => e.Id == house.Id);
            if (check != null)
             return new HouseResponse(false, "House doest not exist");
            _context.Houses.Add(house);
            await _context.SaveChangesAsync();
            return new HouseResponse(true, "House added");


        }

        public async Task<HouseResponse> DeleteHouseAsync(int id)
        {
            var house = await _context.Houses.FindAsync(id);

            if(house == null)
                return  new HouseResponse(false, "House not found");

            _context.Houses.Remove(house);
            await _context.SaveChangesAsync();
            return new HouseResponse(false, "House deleted");
        }

        public async Task<List<House>> GetAllHouseAsync()
        {
            return await _context.Houses.AsNoTracking().ToListAsync();
        }

        public async Task<House> GetHouseByIdAsync(int id)
        {
            return await _context.Houses.FindAsync(id);
        }

        public async Task<HouseResponse> UpdateHouseAsync(House house)
        {
            _context.Houses.Update(house);
            await _context.SaveChangesAsync();
            return new HouseResponse(true, "House Updated");
        }
    }
}

