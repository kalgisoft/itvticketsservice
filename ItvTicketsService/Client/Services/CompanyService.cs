using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        public CurrentUser LoggedInUser { get; set; }

        public CompanyService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        public async Task<List<Company>> GetCompanyList()
        {
            /*
            var result = await _httpClient.PostAsJsonAsync<CurrentUser>("api/Company/GetCompanies", LoggedInUser);
            return await result.Content.ReadFromJsonAsync<List<Company>>();
            */

            return await _httpClient.GetFromJsonAsync<List<Company>>("api/Company/GetCompanies");
        }

        public async Task<Company> Company_GetOne(int id)
        {
            return await _httpClient.GetFromJsonAsync<Company>("api/Company/Company_GetOne/"+id.ToString());
        }

        public async Task<int> CompanyInsert(Company cp)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Company/CompanyInsert/", cp);
            return await result.Content.ReadFromJsonAsync<int>();
        }

        public async Task<Company> CompanyUpdate(Company cp)
        {
            var result = await _httpClient.PutAsJsonAsync("api/Company/CompanyUpdate/", cp);
            return await result.Content.ReadFromJsonAsync<Company>();
        }

        public async Task<HttpResponseMessage> CompanyDelete(int id)
        {
            return await _httpClient.DeleteAsync("api/Company/CompanyDelete/" + id.ToString());
        }

    }
}
