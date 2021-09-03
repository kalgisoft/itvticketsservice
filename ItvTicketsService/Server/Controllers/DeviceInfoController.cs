using ItvTicketsService.Server.Data;
using ItvTicketsService.Server.Models;
using ItvTicketsService.Shared.Models;
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
    public class DeviceInfoController : ControllerBase
    {
        private readonly IDeviceInfoStore<DeviceInfo> _deviceInfoStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public DeviceInfoController(IDeviceInfoStore<DeviceInfo> deviceInfoStore, UserManager<ApplicationUser> userManager)
        {
            _deviceInfoStore = deviceInfoStore;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<ActionResult<int>> DeviceInfoUpsert(DeviceInfo newDevInfo)
        {
            int newDeviceId = -1;
            try
            {
                if (newDevInfo == null)
                {
                    return BadRequest();
                }

                newDeviceId = await _deviceInfoStore.DeviceInfoUpsert(newDevInfo);
                return newDeviceId;
            }
            catch (Exception ex)
            {
                string sss = ex.Message;
                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Error retrieving data from database");
            }
        }

        //Get DeviceInfo by dev code
        [HttpGet("{code}")]
        public async Task<ActionResult<DeviceInfo>> Device_GetInfoByCode(string code)
        {
            try
            {
                var result = await _deviceInfoStore.Device_GetInfoByCode(code);
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

        [HttpDelete("{code}")]
        public async Task<ActionResult<DeviceInfo>> DeviceInfoDelete(string code)
        {
            try
            {
                var devinfoToDelete = await _deviceInfoStore.Device_GetInfoByCode(code);
                if (devinfoToDelete == null)
                {
                    return NotFound($"DeviceInfo with code={code} not found");
                }
                var result = await _deviceInfoStore.DeviceInfoDelete(code);

                return Ok(devinfoToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
    }
}
