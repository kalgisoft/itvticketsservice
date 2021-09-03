using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface IAzureStorageService
    {
        Task<List<string>> GetContainerList();
        Task<List<string>> GetContainerFileList(string container);
        Task<string> FileUpload(MultipartFormDataContent obj);
        Task<HttpResponseMessage> DeleteFile(string blobName);
    }
}
