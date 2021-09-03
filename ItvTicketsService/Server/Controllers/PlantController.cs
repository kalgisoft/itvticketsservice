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

    public class PlantController : ControllerBase
    {
        private readonly IPlantStore<Plant> _plantStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlantController(IPlantStore<Plant> plantStore, UserManager<ApplicationUser> userManager)
        {
            _plantStore = plantStore;
            _userManager = userManager;
        }

        //Get Plant List
        [HttpGet]
        public async Task<ActionResult<List<Plant>>> GetPlants()
        {
            try
            {
                return Ok(await _plantStore.PlantList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        //Get Plant by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Plant>> Plant_GetOne(int id)
        {
            try
            {
                var result = await _plantStore.Plant_GetOne(id);
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

        //Get Plant by id
        //oppure http patch
        [HttpPut]
        public async Task<ActionResult<Plant>> PlantUpdate(Plant cmp)
        {
            try
            {
                var plantToUpdate = await _plantStore.Plant_GetOne(cmp.Id);
                if (plantToUpdate == null)
                {
                    return NotFound($"Plant with Id = {cmp.Id} not found");
                }
                await _plantStore.PlantUpdate(cmp);

                return cmp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> PlantInsert(Plant newPlant)
        {
            try
            {
                if (newPlant == null)
                {
                    return BadRequest();
                }

                int newPlantId = await _plantStore.PlantInsert(newPlant);
                return Ok(newPlantId);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Error retrieving data from database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Plant>> PlantDelete(int id)
        {
            try
            {
                var plantToDelete = await _plantStore.Plant_GetOne(id);
                if (plantToDelete == null)
                {
                    return NotFound($"Plant with Id={id} not found");
                }
                var result = await _plantStore.PlantDelete(id);

                return Ok(plantToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
    }
}
