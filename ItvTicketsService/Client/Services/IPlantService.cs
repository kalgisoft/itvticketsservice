using ItvTicketsService.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface IPlantService
    {
        Task<List<Plant>> GetPlantList();
        Task<Plant> Plant_GetOne(int id);
        Task<int> PlantInsert(Plant cp);
        Task<Plant> PlantUpdate(Plant cp);
        Task<HttpResponseMessage> PlantDelete(int id);
    }
}
