using Dapper;
using ItvTicketsService.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Data
{
    public interface IPlantStore<TPlant> : IDisposable where TPlant : class
    {
        Task<int> PlantInsert(TPlant plant);
        Task<List<TPlant>> PlantList();
        Task<TPlant> Plant_GetOne(int Id);
        Task<IdentityResult> PlantUpdate(TPlant plant);
        Task<IdentityResult> PlantDelete(int Id);
    }

    public class PlantStore : IPlantStore<Plant>
    {
        private readonly string _connectionString;

        public PlantStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
            //nothing to dispose
        }

        public async Task<IdentityResult> PlantDelete(int Id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spPlant_Delete", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<int> PlantInsert(Plant plant)
        {
            int iRet = -1;

            if (plant == null)
            {
                throw new ArgumentNullException("Plant null data");
            }

            if (string.IsNullOrEmpty(plant.Name))
            {
                throw new ArgumentNullException(nameof(plant.Name));
            }

            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Name", plant.Name, DbType.String);
                parameters.Add("StreetAddress", plant.StreetAddress, DbType.String);
                parameters.Add("City", plant.City, DbType.String);
                parameters.Add("State", plant.State, DbType.String);
                parameters.Add("ZipCode", plant.ZipCode, DbType.String);
                parameters.Add("Email", plant.Email, DbType.String);
                parameters.Add("Phone", plant.Phone, DbType.String);
                parameters.Add("IdCompany", plant.IdCompany, DbType.Int32);

                parameters.Add("@foo", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                // Stored procedure method
                await conn.ExecuteAsync("spPlant_Insert", parameters, commandType: CommandType.StoredProcedure);

                iRet = parameters.Get<int>("@foo");
            }

            return iRet;
        }

        public async Task<IdentityResult> PlantUpdate(Plant plant)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", plant.Id, DbType.String);
                parameters.Add("Name", plant.Name, DbType.String);
                parameters.Add("StreetAddress", plant.StreetAddress, DbType.String);
                parameters.Add("City", plant.City, DbType.String);
                parameters.Add("State", plant.State, DbType.String);
                parameters.Add("ZipCode", plant.ZipCode, DbType.String);
                parameters.Add("Email", plant.Email, DbType.String);
                parameters.Add("Phone", plant.Phone, DbType.String);
                parameters.Add("IdCompany", plant.IdCompany, DbType.Int32);

                await conn.ExecuteAsync("spPlant_Update", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<Plant> Plant_GetOne(int Id)
        {
            Plant plant = new Plant();
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                plant = await conn.QueryFirstOrDefaultAsync<Plant>("spPlant_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }

            return plant;
        }

        public async Task<List<Plant>> PlantList()
        {
            IEnumerable<Plant> plants;
            using (var conn = new SqlConnection(_connectionString))
            {
                plants = await conn.QueryAsync<Plant>("spPlant_List", commandType: CommandType.StoredProcedure);
            }
            return plants.ToList();
        }
    }
}
