using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    /// <summary>
    /// contains methods to manage tickets. Add/Update/Get tickets
    /// </summary>
    public class TicketService : ITicketService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;
        public CurrentUser LoggedInUser { get; set; }
        public Tickets TickettoInsert { get; set; }

        public TicketService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        /// <summary>
        /// used to load tickets history for logged in user.
        /// In case of admin user, it will show all tickets
        /// </summary>
        /// <returns></returns>
        public async Task Load()
        {
            try
            {
                TickettoInsert = new Tickets();
                Tickets = new List<Tickets>();
                LoggedInUser = await _authService.CurrentUserInfo();
                Tickets = await GetTicketsByPlantId();
                TicketStatuses = await _httpClient.GetFromJsonAsync<List<TicketStatusModel>>("api/ticket/GetTicketStatuses");
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw ex;
            }
        }

        public async Task LoadByDevice(string devCode)
        {
            try
            {
                TickettoInsert = new Tickets();
                //Tickets = new List<Tickets>();
                Tickets.Clear();

                //LoggedInUser = await _authService.CurrentUserInfo();
                Tickets = await GetTicketsByDevCode(devCode);
                //TicketStatuses = await _httpClient.GetFromJsonAsync<List<TicketStatusModel>>("api/ticket/GetTicketStatuses");
                int kk = 0;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw ex;
            }
        }

        public async Task LoadByClientId(int id)
        {
            try
            {
                TickettoInsert = new Tickets();
                //Tickets = new List<Tickets>();
                Tickets.Clear();
                //LoggedInUser = await _authService.CurrentUserInfo();
                Tickets = await GetTicketsByClientId(id);
                //TicketStatuses = await _httpClient.GetFromJsonAsync<List<TicketStatusModel>>("api/ticket/GetTicketStatuses");
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw ex;
            }
        }


        /// <summary>
        /// stores all statues for ticket
        /// </summary>
        public List<TicketStatusModel> TicketStatuses { get; set; }

        public List<Tickets> Tickets { get; set; }

        /// <summary>
        /// Method gets all tickets for company name.
        /// Takes user as input
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tickets>> GetTicketsByPlantId()
        {
            var result = await _httpClient.PostAsJsonAsync<CurrentUser>("api/ticket/TicketsByPlantId", LoggedInUser);
            return await result.Content.ReadFromJsonAsync<List<Tickets>>();
        }

        /// <summary>
        /// Method gets all tickets for a selected plant.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tickets>> Tickets_GetByPlantId(int plantId)
        {
            return await _httpClient.GetFromJsonAsync<List<Tickets>>("api/ticket/Tickets_GetByPlantId/" + plantId.ToString());
        }


        /// <summary>
        /// Method gets all tickets for a selected device.
        /// Takes user as input
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tickets>> GetTicketsByDevCode(string devCode)
        {
            return await _httpClient.GetFromJsonAsync<List<Tickets>>("api/ticket/TicketsByDevCode/" + devCode);
        }

        /// <summary>
        /// Method gets all tickets for a selected user client.
        /// Takes user as input
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tickets>> GetTicketsByClientId(int id)
        {
            return await _httpClient.GetFromJsonAsync<List<Tickets>>("api/ticket/TicketsByClientId/" + id.ToString());
        }

        public async Task<Tickets> GetTicketsById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Tickets>("api/ticket/Ticket_GetOne/" + id.ToString());
        }

        public async Task<List<Tickets>> Tickets_GetByDate(DateTime dateFrom, DateTime dateTo)
        {
            string dFrom = dateFrom.ToString("yyyyMMdd");
            string dTo = dateTo.ToString("yyyyMMdd");

            return await _httpClient.GetFromJsonAsync<List<Tickets>>("api/ticket/TicketsByDate/" + dFrom + @"/" + dTo);
        }


        public async Task<HttpResponseMessage> UpdateTicket(Tickets ticket, bool updateStatus)
        {
            /*
            //stato corrente ticket
            Tickets cTicket = await GetTicketsById(ticket.TicketId);

            bool advanceStatus = true;
            if (updateStatus)
            {
                if (cTicket.TicketStatusId == (int)TicketStatusMaster.ToDo)
                {
                    cTicket.OpenDate = DateTime.Now;
                    cTicket.TeamId = LoggedInUser.UserId;
                    if (LoggedInUser.Role.Contains(RoleType.Client))
                    {
                        cTicket.TicketStatusId = (int)TicketStatusMaster.Aborted;
                        cTicket.TicketStatus = TicketStatuses.First(x => x.TicketStatusId == cTicket.TicketStatusId).TicketStatus;
                        cTicket.CloseDate = DateTime.Now;
                        advanceStatus = false;
                    }
                }

                if (cTicket.TicketStatusId == (int)TicketStatusMaster.Approve)
                {
                    cTicket.CloseDate = DateTime.Now;
                }

                if (advanceStatus)
                {
                    if (cTicket.TicketStatusId != (int)TicketStatusMaster.Aborted)
                    {
                        cTicket.TicketStatusId = ticket.TicketStatusId + 1;
                        cTicket.TicketStatus = TicketStatuses.First(x => x.TicketStatusId == cTicket.TicketStatusId).TicketStatus;
                    }
                }
            }

            //agiorna ticket
            ticket = cTicket;
            */

            var result = await _httpClient.PutAsJsonAsync("api/ticket/UpdateTicket", ticket);
            return result;
        }

        public async Task<HttpResponseMessage> DeleteTicket(Tickets ticket)
        {
            var result = await _httpClient.PutAsJsonAsync("api/ticket/DeleteTicket", ticket);
            return result;
        }


        /// <summary>
        /// Method is used to Insert ticket.
        /// </summary>
        /// <returns></returns>
        public async Task AddTicket() {
            var result = await _httpClient.PostAsJsonAsync<Tickets>("api/ticket/CreateTicket", TickettoInsert);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }
    }
}
