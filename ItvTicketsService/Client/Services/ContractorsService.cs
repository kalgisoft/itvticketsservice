using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class ContractorsService : IContractorsService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        public CurrentUser LoggedInUser { get; set; }

        public ContractorsService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }


        public async Task<HttpResponseMessage> ContractorsDelete(int id)
        {
            return await _httpClient.DeleteAsync("api/Contractors/ContractorsDelete/" + id.ToString());
        }

        public async Task<int> ContractorsInsert(Contractor cntr)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Contractors/ContractorsInsert/", cntr);
            return await result.Content.ReadFromJsonAsync<int>();
        }

        public async Task<Contractor> ContractorsUpdate(Contractor cntr)
        {
            var result = await _httpClient.PutAsJsonAsync("api/Contractors/ContractorsUpdate/", cntr);
            return await result.Content.ReadFromJsonAsync<Contractor>();
        }

        public async Task<Contractor> Contractors_GetOne(int id)
        {
            return await _httpClient.GetFromJsonAsync<Contractor>("api/Contractors/Contractors_GetOne/" + id.ToString());
        }

        public async Task<List<Contractor>> GetContractorsList()
        {
            return await _httpClient.GetFromJsonAsync<List<Contractor>>("api/Contractors/GetContractors");
        }
    }
}
