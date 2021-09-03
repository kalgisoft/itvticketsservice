using System;
using System.Collections.Generic;
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

        public Task<HttpResponseMessage> DeleteFile(string blobName)
        {
            throw new NotImplementedException();
        }

        public async Task<string> FileUpload(MultipartFormDataContent obj)
        {
            /*
            var response = await _httpClient.PostAsync("api/Upload/Upload/", obj);
            return await response.Content.ReadAsStringAsync();
            */
  
            var response = await _httpClient.PostAsync("api/Image/upload?model=", obj);
            return "";
        }

        public async Task<List<string>> GetContainerFileList(string container)
        {
            //var res = await _httpClient.GetAsync("api/Image/List/" + container);
            //return null;

            var res = await _httpClient.GetFromJsonAsync<List<string>>("api/Image/List?container=" + container);
            return res;
        }

        public Task<List<string>> GetContainerList()
        {
            throw new NotImplementedException();
        }
    }
}
