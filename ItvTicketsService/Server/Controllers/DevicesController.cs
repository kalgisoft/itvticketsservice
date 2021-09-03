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
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceStore<Device> _deviceStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public DeviceController(IDeviceStore<Device> deviceStore, UserManager<ApplicationUser> userManager)
        {
            _deviceStore = deviceStore;
            _userManager = userManager;
        }


        //Get Devices List
        [HttpGet]
        public async Task<ActionResult<List<Device>>> GetDevices()
        {
            try
            {
                return Ok(await _deviceStore.DeviceList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        //Get Device by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Device>> Device_GetOne(int id)
        {
            try
            {
                var result = await _deviceStore.Device_GetOne(id);
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

        //Update Device by id
        [HttpPut]
        public async Task<ActionResult<Device>> DeviceUpdate(Device dvc)
        {
            try
            {
                var deviceToUpdate = await _deviceStore.Device_GetOne(dvc.Id);
                if (deviceToUpdate == null)
                {
                    return NotFound($"Device with Id = {dvc.Id} not found");
                }
                await _deviceStore.DeviceUpdate(dvc);

                return dvc;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> DeviceInsert(Device newDevice)
        {
            try
            {
                if (newDevice == null)
                {
                    return BadRequest();
                }

                int newDeviceId = await _deviceStore.DeviceInsert(newDevice);
                return newDeviceId;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Error retrieving data from database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Device>> DeviceDelete(int id)
        {
            try
            {
                var deviceToDelete = await _deviceStore.Device_GetOne(id);
                if (deviceToDelete == null)
                {
                    return NotFound($"Device with Id={id} not found");
                }
                var result = await _deviceStore.DeviceDelete(id);

                return Ok(deviceToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        //Get Devices List
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<Device>>> GetDevicesForPlant(int id)
        {
            try
            {
                return Ok(await _deviceStore.DevicesForPlant(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

    }
}
