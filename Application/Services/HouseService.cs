using System;
using System.Net.Http.Json;
using ApplicationHouse.Dtos;
using DomainHouse.Entities;

namespace ApplicationHouse.Services
{
	public class HouseService:IHouseService
	{
        private readonly HttpClient _httpClient;

        public HouseService( HttpClient httpClient)
		{
          this._httpClient = httpClient;

        } 

        public async Task<HouseResponse> CreateHouseAsync(House house)
        {
            var data = await _httpClient.PostAsJsonAsync("api/house", house);
            var response = await data.Content.ReadFromJsonAsync<HouseResponse>();
            return response!;
        }

        public async Task<HouseResponse> DeleteHouseAsync(int id)
        {
            var data = await _httpClient.DeleteAsync($"api/house/{id}");
            var response = await data.Content.ReadFromJsonAsync<HouseResponse>();
            return response!;
        }

        public async  Task<List<House>> GetAllHouseAsync() => await _httpClient.GetFromJsonAsync<List<House>>("api/house");
        

        public async Task<House> GetHouseByIdAsync(int id) => await _httpClient.GetFromJsonAsync<House>($"api/house/{id}");
        

        public async Task<HouseResponse> UpdateHouseAsync(House house)
        {
            var data = await _httpClient.PutAsJsonAsync("api/house", house);
            var response = await data.Content.ReadFromJsonAsync<HouseResponse>();
            return response!;

        }
    }
}

