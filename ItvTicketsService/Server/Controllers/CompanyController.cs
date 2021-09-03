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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyStore<Company> _companyStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public CompanyController(ICompanyStore<Company> companyStore, UserManager<ApplicationUser> userManager)
        {
            _companyStore = companyStore;
            _userManager = userManager;
        }


        //GetCompanyList
        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetCompanies()
	    {
            try
            {
                return Ok(await _companyStore.CompanyList());
                
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
	    }

        //Get Company by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Company>> Company_GetOne(int id)
        {
            try
            {
                var result = await _companyStore.Company_GetOne(id);
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

        //Get Company by id
        //oppure http patch
        [HttpPut] 
        public async Task<ActionResult<Company>> CompanyUpdate(Company cmp)
        {
            try
            {
                var companyToUpdate = await _companyStore.Company_GetOne(cmp.Id);
                if (companyToUpdate==null)
                {
                    return NotFound($"Employee with Id = {cmp.Id} not found");
                }
                await _companyStore.CompanyUpdate(cmp);

                return cmp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> CompanyInsert(Company newCompany)
        {
            try
            {
                if (newCompany == null)
                {
                    return BadRequest();
                }
 
                int newCompanyId = await _companyStore.CompanyInsert(newCompany);
                return Ok(newCompanyId);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Error retrieving data from database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Company>> CompanyDelete(int id)
        {
            try
            {
                var companyToDelete = await _companyStore.Company_GetOne(id);
                if (companyToDelete==null)
                {
                    return NotFound($"Company with Id={id} not found");
                }
                var result = await _companyStore.CompanyDelete(id);

                return Ok(companyToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
    }
}
