using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface IDeviceInfoService
    {
        Task<DeviceInfo> Device_GetInfoByCode(string code);
        Task<int> DeviceInfoUpsert(DeviceInfo cp);
        Task<HttpResponseMessage> DeviceInfoDelete(string code);
    }
}
