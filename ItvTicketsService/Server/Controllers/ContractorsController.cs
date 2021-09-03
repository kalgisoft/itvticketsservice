using ItvTicketsService.Shared.Models;
using ItvTicketsService.Server.Data;
using ItvTicketsService.Server.Models;
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
    public class ContractorsController : ControllerBase
    {
        private readonly IContractorsStore<Contractor> _contractorsStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public ContractorsController(IContractorsStore<Contractor> contractorsStore, UserManager<ApplicationUser> userManager)
        {
            _contractorsStore = contractorsStore;
            _userManager = userManager;
        }

        //Get Contractors List
        [HttpGet]
        public async Task<ActionResult<List<Contractor>>> GetContractors()
        {
            try
            {
                return Ok(await _contractorsStore.ContractorsList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        //Get Contractor by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Contractor>> Contractors_GetOne(int id)
        {
            try
            {
                var result = await _contractorsStore.Contractors_GetOne(id);
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

        //oppure http patch
        [HttpPut]
        public async Task<ActionResult<Contractor>> ContractorsUpdate(Contractor cntr)
        {
            try
            {
                var contractorToUpdate = await _contractorsStore.Contractors_GetOne(cntr.Id);
                if (contractorToUpdate == null)
                {
                    return NotFound($"Contractor with Id = {cntr.Id} not found");
                }
                await _contractorsStore.ContractorsUpdate(cntr);

                return cntr;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> ContractorsInsert(Contractor newContractor)
        {
            try
            {
                if (newContractor == null)
                {
                    return BadRequest();
                }

                int newContractorId = await _contractorsStore.ContractorsInsert(newContractor);
                return Ok(newContractorId);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Error retrieving data from database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Contractor>> ContractorsDelete(int id)
        {
            try
            {
                var contractorToDelete = await _contractorsStore.Contractors_GetOne(id);
                if (contractorToDelete == null)
                {
                    return NotFound($"Contractor with Id={id} not found");
                }
                var result = await _contractorsStore.ContractorsDelete(id);

                return Ok(contractorToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
    }
}
