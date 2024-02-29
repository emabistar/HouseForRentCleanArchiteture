using System;
using ApplicationHouse.Contracts;
using ApplicationHouse.Dtos;
using ArchitectureHouse.Data;
using DomainHouse.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureHouse.Repositories
{
    public class ModeRepository : IMode
    {
        private readonly HouseContext _context;
        public ModeRepository(HouseContext context)
        {
            _context = context;
        }
       

        public async Task<ModeResponse> CreateModeAsync(Mode mode)
        {
            var check = _context.Modes.FirstOrDefault(e => e.Id == mode.Id);
            if (check != null)
                return new ModeResponse(false, "House doest not exist");
            _context.Modes.Add(mode);
            await _context.SaveChangesAsync();
            return new ModeResponse(true, "Mode added");
        }

        public async Task<List<Mode>> GetAllAsync()
        {
            return await _context.Modes.AsNoTracking().ToListAsync();
        }
    }
}

