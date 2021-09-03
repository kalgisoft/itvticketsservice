using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public interface ITicketService
    {
        Task Load();

        Task LoadByDevice(string devCode);

        Task LoadByClientId(int id);

        Task<List<Tickets>> GetTicketsByPlantId();
        Task<List<Tickets>> Tickets_GetByPlantId(int id);

        Task<Tickets> GetTicketsById(int id);

        Task<List<Tickets>> Tickets_GetByDate(DateTime dateFrom, DateTime dateTo);

        List<TicketStatusModel> TicketStatuses { get; set; }

        Task<HttpResponseMessage> UpdateTicket(Tickets ticket, bool updateStatus);
        CurrentUser LoggedInUser { get; set; }
        List<Tickets> Tickets { get; set; }
        Tickets TickettoInsert { get; set; }

        Task AddTicket();
        Task<HttpResponseMessage> DeleteTicket(Tickets ticket);
    }
}
