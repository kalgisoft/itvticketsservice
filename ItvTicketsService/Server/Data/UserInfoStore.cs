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
    public interface IUserInfoStore<TUserInfo> : IDisposable where TUserInfo : class
    {
        Task<List<TUserInfo>> UserInfoList(int idRole);
        Task<TUserInfo> UserInfo_GetOne(int id);
        Task<int> UserInfo_Upsert(int client, int plant);
        Task<IdentityResult> UserInfo_Delete(int userid, int plantid);
        Task<IdentityResult> UserInfo_DeleteAll(int userid);
        Task<bool> UserInfo_ChangeRole(int client, int role);
    }

    public class UserInfoStore : IUserInfoStore<UserInfo>
    {
        private readonly string _connectionString;

        public UserInfoStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
           
        }

        public async Task<List<UserInfo>> UserInfoList(int idRole)
        {
            IEnumerable<UserInfo> users;
            string pr = "client";
            if (idRole == 1) pr = "admin";
            if (idRole == 2) pr = "team";

            var parameters = new DynamicParameters();
            parameters.Add("@NNAME", pr.ToUpper(), DbType.String);
            using (var conn = new SqlConnection(_connectionString))
            {
                users = await conn.QueryAsync<UserInfo>("spUsers", parameters, commandType: CommandType.StoredProcedure);
            }

            return users.ToList();
        }

        public async Task<UserInfo> UserInfo_GetOne(int id)
        {
            UserInfo user = new UserInfo();

            var parameters = new DynamicParameters();
            parameters.Add("@client", id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                IEnumerable<UserInfo> users = await conn.QueryAsync<UserInfo>("spUsers_GetOne", parameters, commandType: CommandType.StoredProcedure);

                var pp = await conn.QueryAsync<int>("spPlantsToClient_ListPlants", parameters, commandType: CommandType.StoredProcedure);
                List<int> plants = pp.ToList();
                
                user.Id = users.First().Id;
                user.UserName = users.First().UserName;
                user.UserRole = users.First().UserRole;
                user.UserRoleName = users.First().UserRoleName;

                user.Plants = plants;
            }

            return user;
        }

        public async Task<int> UserInfo_Upsert(int client, int plant)
        {
            int iRet = -1;

            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("client", client, DbType.Int32);
                parameters.Add("plant", plant, DbType.Int32);
 
                // Stored procedure method
                await conn.ExecuteAsync("spPlantsToClient_Upsert", parameters, commandType: CommandType.StoredProcedure);

                iRet = 0;
            }

            return iRet;
        }

        public async Task<IdentityResult> UserInfo_Delete(int userid, int plantid)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@client", userid, DbType.Int32);
            parameters.Add("@plant", plantid, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spPlantsToClient_Delete", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> UserInfo_DeleteAll(int userid)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@client", userid, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spPlantsToClient_DeleteAll", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<bool> UserInfo_ChangeRole(int client, int role)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@client", client, DbType.Int32);
            parameters.Add("@role", role, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spApplicationUserRole_ChangeRole", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }
    }
}
