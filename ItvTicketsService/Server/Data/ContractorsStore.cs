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
    public interface IContractorsStore<TContractor> : IDisposable where TContractor : class
    {
        Task<int> ContractorsInsert(TContractor contractor);
        Task<List<TContractor>> ContractorsList();
        Task<TContractor> Contractors_GetOne(int Id);
        Task<IdentityResult> ContractorsUpdate(TContractor contractor);
        Task<IdentityResult> ContractorsDelete(int Id);
    }

    public class ContractorsStore : IContractorsStore<Contractor>
    {
        private readonly string _connectionString;

        public ContractorsStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        
        public async Task<IdentityResult> ContractorsDelete(int Id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spContractors_Delete", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<int> ContractorsInsert(Contractor contractor)
        {
            int iRet = -1;

            if (contractor == null)
            {
                throw new ArgumentNullException("Contractor null data");
            }

            if (string.IsNullOrEmpty(contractor.Name))
            {
                throw new ArgumentNullException(nameof(contractor.Name));
            }

            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Name", contractor.Name, DbType.String);
                parameters.Add("@foo", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                // Stored procedure method
                await conn.ExecuteAsync("spContractors_Insert", parameters, commandType: CommandType.StoredProcedure);

                iRet = parameters.Get<int>("@foo");
            }

            return iRet;
        }

        public async Task<List<Contractor>> ContractorsList()
        {
            IEnumerable<Contractor> contractors;
            using (var conn = new SqlConnection(_connectionString))
            {
                contractors = await conn.QueryAsync<Contractor>("spContractors_List", commandType: CommandType.StoredProcedure);
            }

            return contractors.ToList();
        }

        public async Task<IdentityResult> ContractorsUpdate(Contractor contractor)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", contractor.Id, DbType.Int32);
                parameters.Add("Name", contractor.Name, DbType.String);

                await conn.ExecuteAsync("spContractors_Update", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<Contractor> Contractors_GetOne(int Id)
        {
            Contractor cntr = new Contractor();
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                cntr = await conn.QueryFirstOrDefaultAsync<Contractor>("spContractors_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }

            return cntr;
        }

        public void Dispose()
        {
            //
        }
    }
}
