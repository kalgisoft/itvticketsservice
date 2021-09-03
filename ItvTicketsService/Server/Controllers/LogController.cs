using ItvTicketsService.Server.Data;
using ItvTicketsService.Shared.Models;
using ItvTicketsService.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class LogController : ControllerBase
    {
        private readonly ILogStore<Log> _logStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public LogController(ILogStore<Log> logStore, UserManager<ApplicationUser> userManager)
        {
            _logStore = logStore;
            _userManager = userManager;
        }

        //Get Log List
        [HttpGet]
        public async Task<ActionResult<List<Log>>> GetLogs()
        {
            try
            {
                return Ok(await _logStore.LogList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        //Get Log by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Log>> Log_GetOne(int id)
        {
            try
            {
                var result = await _logStore.Log_GetOne(id);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> LogInsert(Log newLog)
        {
            try
            {
                if (newLog == null)
                {
                    return BadRequest();
                }

                int newLogId = await _logStore.LogInsert(newLog);
                return Ok(newLogId);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Error retrieving data from database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Log>> LogDelete(int id)
        {
            try
            {
                var logToDelete = await _logStore.Log_GetOne(id);
                if (logToDelete == null)
                {
                    return NotFound($"Log with Id={id} not found");
                }
                var result = await _logStore.LogDelete(id);

                return Ok(logToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
    }
}
