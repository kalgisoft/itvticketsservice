using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class AzureStorageService : IAzureStorageService
    {
        private readonly HttpClient _httpClient;

        public AzureStorageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> DeleteFile(string blobName)
        {
            DeviceImageFile deviceImageFile = new DeviceImageFile();
            deviceImageFile.Name = blobName;
            return await _httpClient.PostAsJsonAsync("api/Image/Delete", deviceImageFile);
        }


        public async Task<string> FileUpload(MultipartFormDataContent content)
        {
            string imgUrl = string.Empty;
            try
            {
                var response = await _httpClient.PostAsync("api/Image/upload", content);
                imgUrl = await response.Content.ReadAsStringAsync();
            }
            catch(Exception ex)
            {
                imgUrl = ex.Message;
            }
            return imgUrl;
        }

        public async Task<List<string>> GetContainerFileList(string container)
        {
            var res = await _httpClient.GetFromJsonAsync<List<string>>("api/Image/List?container=" + container);
            return res;
        }

        public Task<List<string>> GetContainerList()
        {
            throw new NotImplementedException();
        }
    }
}
