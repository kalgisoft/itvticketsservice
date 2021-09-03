using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class DeviceImagesService : IDeviceImagesService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

         public DeviceImagesService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        public async Task<List<string>> DeviceImages(string code)
        {
            return await _httpClient.GetFromJsonAsync<List<string>>("api/DeviceImages/DeviceImages/" + code);
        }

        public async Task<byte[]> GetImageBytes(string code, string file)
        {
            return await _httpClient.GetByteArrayAsync("api/DeviceImages/GetImageFile/" + code + @"/" + file);
        }
    }
}
