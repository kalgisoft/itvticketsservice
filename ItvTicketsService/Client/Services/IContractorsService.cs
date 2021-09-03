using ItvTicketsService.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface IContractorsService
    {
        Task<List<Contractor>> GetContractorsList();
        Task<Contractor> Contractors_GetOne(int id);
        Task<int> ContractorsInsert(Contractor cntr);
        Task<Contractor> ContractorsUpdate(Contractor cntr);
        Task<HttpResponseMessage> ContractorsDelete(int id);
    }
}
