using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface ICompanyService
    {
        Task<List<Company>> GetCompanyList();
        Task<Company> Company_GetOne(int id);
        Task<int> CompanyInsert(Company cp);
        Task<Company> CompanyUpdate(Company cp);
        Task<HttpResponseMessage> CompanyDelete(int id);
    }
}
