using System;
using System.Net.Http.Json;
using ApplicationHouse.Contracts;
using ApplicationHouse.Dtos;
using DomainHouse.Entities;

namespace ApplicationHouse.Services
{
	public class ModeService:IModeService
	{
        private readonly HttpClient _httpClient;
        public ModeService(HttpClient httpClient)
		{
            _httpClient = httpClient;
		}

        public async  Task<ModeResponse> CreateModeAsync(Mode mode)
        {
            var data = await _httpClient.PostAsJsonAsync("api/Mode", mode);
            var response = await data.Content.ReadFromJsonAsync<ModeResponse>();
            return response!;
        }

        public  async Task<List<Mode>> GetAllAsync() => await _httpClient.GetFromJsonAsync<List<Mode>>("api/mode");


    }
}

