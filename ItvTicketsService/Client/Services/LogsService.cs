using ItvTicketsService.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class LogsService : ILogsService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        public CurrentUser LoggedInUser { get; set; }

        public LogsService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        public async Task<List<Log>> GetLogList()
        {
            return await _httpClient.GetFromJsonAsync<List<Log>>("api/Log/GetLogs");
        }

        public async Task<HttpResponseMessage> LogDelete(int id)
        {
            return await _httpClient.DeleteAsync("api/Log/LogDelete/" + id.ToString());
        }

        public async Task<int> LogInsert(Log lg)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Log/LogInsert/", lg);
            return await result.Content.ReadFromJsonAsync<int>();
        }

        public async Task<Log> Log_GetOne(int id)
        {
            return await _httpClient.GetFromJsonAsync<Log>("api/Log/Log_GetOne/" + id.ToString());
        }
    }
}
