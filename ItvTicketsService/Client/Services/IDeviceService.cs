using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface IDeviceService
    {
        Task<List<Device>> GetDeviceList();
        Task<Device> Device_GetOne(int id);
        Task<int> DeviceInsert(Device cp);
        Task<Device> DeviceUpdate(Device cp);
        Task<HttpResponseMessage> DeviceDelete(int id);
        Task<List<Device>> GetDevicesForPlant(int plantId);
    }
}
