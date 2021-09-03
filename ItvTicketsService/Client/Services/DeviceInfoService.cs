using ItvTicketsService.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class DeviceInfoService : IDeviceInfoService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        public CurrentUser LoggedInUser { get; set; }

        public DeviceInfoService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        public async  Task<HttpResponseMessage> DeviceInfoDelete(string code)
        {
            return await _httpClient.DeleteAsync("api/DeviceInfo/DeviceInfoDelete/" + code);
        }

        public async Task<int> DeviceInfoUpsert(DeviceInfo cp)
        {
            var response = await _httpClient.PostAsJsonAsync("api/DeviceInfo/DeviceInfoUpsert/", cp);
            response.EnsureSuccessStatusCode();
            var devID = await response.Content.ReadFromJsonAsync<int>();
            return devID;
        }

        public async Task<DeviceInfo> Device_GetInfoByCode(string code)
        {
            return await _httpClient.GetFromJsonAsync<DeviceInfo>("api/DeviceInfo/Device_GetInfoByCode/" + code);
        }
    }
}
