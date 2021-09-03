using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class PlantService : IPlantService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        public CurrentUser LoggedInUser { get; set; }

        public PlantService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        public async Task<List<Plant>> GetPlantList()
        {
            return await _httpClient.GetFromJsonAsync<List<Plant>>("api/Plant/GetPlants");
        }

        public async Task<Plant> Plant_GetOne(int id)
        {
            return await _httpClient.GetFromJsonAsync<Plant>("api/Plant/Plant_GetOne/" + id.ToString());
        }

        public async Task<int> PlantInsert(Plant cp)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Plant/PlantInsert/", cp);
            return await result.Content.ReadFromJsonAsync<int>();
        }

        public async Task<Plant> PlantUpdate(Plant cp)
        {
            var result = await _httpClient.PutAsJsonAsync("api/Plant/PlantUpdate/", cp);
            return await result.Content.ReadFromJsonAsync<Plant>();
        }

        public async Task<HttpResponseMessage> PlantDelete(int id)
        {
            return await _httpClient.DeleteAsync("api/Plant/PlantDelete/" + id.ToString());
        }
    }
}
