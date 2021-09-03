using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using ItvTicketsService.Shared.Models;

namespace ItvTicketsService.Server.Data
{
    public interface ICompanyStore<TCompany> : IDisposable where TCompany : class
    {
        Task<int> CompanyInsert(TCompany company);
        Task<List<TCompany>> CompanyList();
        Task<TCompany> Company_GetOne(int Id);
        Task<IdentityResult> CompanyUpdate(TCompany company);
        Task<IdentityResult> CompanyDelete(int Id);
    }

    /// <summary>
    /// /////////////////////
    /// </summary>
    public class CompanyStore : ICompanyStore<Company>
    {
        private readonly string _connectionString;

        public CompanyStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
            //nothing to dispose
        }

        public async Task<IdentityResult> CompanyDelete(int Id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spCompany_Delete", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<int> CompanyInsert(Company company)
        {
            int iRet = -1;

            if (company==null)
            {
                throw new ArgumentNullException("Company null data");
            }

            if (string.IsNullOrEmpty(company.Name))
            {
                throw new ArgumentNullException(nameof(company.Name));
            }

            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Name", company.Name, DbType.String);
                parameters.Add("StreetAddress", company.StreetAddress, DbType.String);
                parameters.Add("City", company.City, DbType.String);
                parameters.Add("State", company.State, DbType.String);
                parameters.Add("ZipCode", company.ZipCode, DbType.String);
                parameters.Add("Email", company.Email, DbType.String);
                parameters.Add("Phone", company.Phone, DbType.String);
                parameters.Add("TicketAmount", company.TicketAmount, DbType.Int32);

                parameters.Add("@foo", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                // Stored procedure method
                await conn.ExecuteAsync("spCompany_Insert", parameters, commandType: CommandType.StoredProcedure);

                iRet = parameters.Get<int>("@foo");
            }

            return iRet;
        }

        public async Task<IdentityResult> CompanyUpdate(Company company)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", company.Id, DbType.String);
                parameters.Add("Name", company.Name, DbType.String);
                parameters.Add("StreetAddress", company.StreetAddress, DbType.String);
                parameters.Add("City", company.City, DbType.String);
                parameters.Add("State", company.State, DbType.String);
                parameters.Add("ZipCode", company.ZipCode, DbType.String);
                parameters.Add("Email", company.Email, DbType.String);
                parameters.Add("Phone", company.Phone, DbType.String);
                parameters.Add("TicketAmount", company.TicketAmount, DbType.Int32);

                await conn.ExecuteAsync("spCompany_Update", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<Company> Company_GetOne(int Id)
        {
            Company company = new Company();
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                company = await conn.QueryFirstOrDefaultAsync<Company>("spCompany_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }

            return company;
        }

        public async Task<List<Company>> CompanyList()
        {
            IEnumerable<Company> companies;
            using (var conn = new SqlConnection(_connectionString))
            {
                companies = await conn.QueryAsync<Company>("spCompany_List", commandType:CommandType.StoredProcedure);
            }
            return companies.ToList();
        }
    }
}
