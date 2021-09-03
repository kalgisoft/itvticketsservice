using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface IDeviceImagesService
    {
        Task<List<string>> DeviceImages(string code);
        Task<byte[]> GetImageBytes(string code, string file);
    }
}

