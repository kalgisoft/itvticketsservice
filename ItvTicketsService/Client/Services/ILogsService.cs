using ItvTicketsService.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface ILogsService
    {
        Task<List<Log>> GetLogList();
        Task<Log> Log_GetOne(int id);
        Task<int> LogInsert(Log lg);
        Task<HttpResponseMessage> LogDelete(int id);
    }
}
