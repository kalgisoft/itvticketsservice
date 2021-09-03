using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        public CurrentUser LoggedInUser { get; set; }

        public DeviceService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        public async Task<List<Device>> GetDeviceList()
        {
            return await _httpClient.GetFromJsonAsync<List<Device>>("api/Device/GetDevices/");
        }

        public async Task<Device> Device_GetOne(int id)
        {
            return await _httpClient.GetFromJsonAsync<Device>("api/Device/Device_GetOne/" + id.ToString());
        }

        public async Task<int> DeviceInsert(Device cp)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Device/DeviceInsert/", cp);
            response.EnsureSuccessStatusCode();
            var devID = await response.Content.ReadFromJsonAsync<int>();
            return devID;
        }

        public async Task<Device> DeviceUpdate(Device cp)
        {
            var result = await _httpClient.PutAsJsonAsync("api/Device/DeviceUpdate/", cp);
            return await result.Content.ReadFromJsonAsync<Device>();
        }

        public async Task<HttpResponseMessage> DeviceDelete(int id)
        {
            return await _httpClient.DeleteAsync("api/Device/DeviceDelete/" + id.ToString());
        }

        public async Task<List<Device>> GetDevicesForPlant(int plantId)
        {
            return await _httpClient.GetFromJsonAsync<List<Device>>("api/Device/GetDevicesForPlant/" + plantId.ToString());
        }
    }
}
