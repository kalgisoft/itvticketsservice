using ItvTicketsService.Server.Data;
using ItvTicketsService.Server.Models;
using ItvTicketsService.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ItvTicketsService.Server.Controllers
{
    /// <summary>
    /// /// contains methods to manage tickets. Add/Update/Get tickets
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TicketController : ControllerBase
    {
        private readonly ITicketsStore<Tickets> _ticketsStore;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogStore<Log> _logManager;

        public TicketController(ITicketsStore<Tickets> ticketsStore, UserManager<ApplicationUser> userManager, ILogStore<Log> logManager)
        {
            _ticketsStore = ticketsStore;
            _userManager = userManager;
            _logManager = logManager;
        }

        [HttpGet]
        public string CheckService()
        {
            return "Service Called";
        }

        /// <summary>
        /// Gets Tickets for logged-in user from his company name and Role.
        /// In case of Admin, Retrieves all tickets
        /// </summary>
        /// <param name="currentUser">Current Logged-in user</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<Tickets>> TicketsByPlantId(CurrentUser currentUser)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var isAdmin = currentUser.Role.Contains(RoleType.Admin);
            //var isTeam = currentUser.Role.Contains(RoleType.Team);
            bool fullList = !currentUser.Role.Contains(RoleType.Client);
            var result = await _ticketsStore.FindByPlantIdAsync(user.Id, fullList);
            return result;
        }

        [HttpGet("{id:int}")]
        public async Task<List<Tickets>> Ticket_GetByPlantId(int id)
        {
            return await _ticketsStore.FindByPlantIdAsync(id, false);
        }


        [HttpGet("{id:int}")]
        public async Task<Tickets> Ticket_GetOne(int id)
        {
            return await _ticketsStore.FindTicketByIdAsync(id);
        }

        [HttpGet("{devcode}")]
        public async Task<List<Tickets>> TicketsByDevCode(string devcode)
        {
            return await _ticketsStore.FindTicketsByDevCode(devcode);
        }

        [HttpGet("{id:int}")]
        public async Task<List<Tickets>> TicketsByClientId(int id)
        {
            return await _ticketsStore.FindTicketsByClientId(id);
        }

        [HttpGet("{from}/{to}")]
        public async Task<List<Tickets>> TicketsByDate(string from, string to)
        {
            return await _ticketsStore.FindTicketsByDateInterval(from, to);
        }


        /// <summary>
        /// Get status for ticket
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<TicketStatusModel>> GetTicketStatuses()
        {
            return await _ticketsStore.GetTicketStatuses();
        }

        /// <summary>
        /// Creates new ticket with default status 1 as ToDo
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public async Task<IActionResult> CreateTicket(Tickets ticket)
        {
            Log lg = new Log();
            lg.CreatedDate = DateTime.Now.ToString();
            
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            lg.UserId = user.Id;
            
            if (string.IsNullOrEmpty(ticket.Reason) )
            {
                return BadRequest();
            }

            var result = await _ticketsStore.CreateAsync(ticket);
            if (!result.Succeeded)
            {
                //lg.UserId = ;
                lg.LogLevel = "Error";
                lg.ExceptionMessage = "Add Ticket Error";
                lg.StackTrace = result.Errors.FirstOrDefault()?.Description;

                return BadRequest(result.Errors.FirstOrDefault()?.Description);
            }

            //lg.UserId = ;
            lg.LogLevel = "Information";
            lg.ExceptionMessage = "New Ticket Added Id="+ticket.TicketId.ToString();
            await _logManager.LogInsert(lg);

            return Ok();
        }

        /// <summary>
        /// Updates ticket, takes ticket detail to update
        /// </summary>
        /// <param name="ticket">ticket detail</param>
        /// <returns></returns>
        public async Task<IdentityResult> UpdateTicket(Tickets ticket)
        {
            return await _ticketsStore.UpdateAsync(ticket);
        }

        /// <summary>
        /// Delete a ticket
        /// </summary>
        /// <param name="ticket">ticket to delete</param>
        /// <returns></returns>
        public async Task<IdentityResult> DeleteTicket(Tickets ticket)
        {
            return await _ticketsStore.DeleteAsync(ticket);
        }
    }
}