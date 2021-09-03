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
    public interface ILogStore<TLog> : IDisposable where TLog : class
    {
        Task<int> LogInsert(TLog log);
        Task<List<TLog>> LogList();
        Task<TLog> Log_GetOne(int Id);
        Task<IdentityResult> LogDelete(int Id);
    }

    public class LogStore : ILogStore<Log>
    {
        private readonly string _connectionString;

        public LogStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
        }

        public async Task<IdentityResult> LogDelete(int Id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LogId", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spLog_Delete", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<List<Log>> LogList()
        {
            IEnumerable<Log> logs;
            using (var conn = new SqlConnection(_connectionString))
            {
                logs = await conn.QueryAsync<Log>("spLog_List", commandType: CommandType.StoredProcedure);
            }
            return logs.ToList();
        }

        public async Task<Log> Log_GetOne(int Id)
        {
            Log log = new Log();
            var parameters = new DynamicParameters();
            parameters.Add("@LogId", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                log = await conn.QueryFirstOrDefaultAsync<Log>("spLog_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }

            return log;
        }

        public async Task<int> LogInsert(Log log)
        {
            int iRet = -1;

            if (log == null)
            {
                throw new ArgumentNullException("Log null data");
            }

            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("LogLevel", log.LogLevel, DbType.String);
                parameters.Add("EventName", log.EventName, DbType.String);
                parameters.Add("Source", log.Source, DbType.String);
                parameters.Add("ExceptionMessage", log.ExceptionMessage, DbType.String);
                parameters.Add("StackTrace", log.StackTrace, DbType.String);
                parameters.Add("CreatedDate", log.CreatedDate, DbType.String);
                parameters.Add("UserId", log.UserId, DbType.Int32);

                parameters.Add("@foo", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                // Stored procedure method
                await conn.ExecuteAsync("spLog_Insert", parameters, commandType: CommandType.StoredProcedure);

                iRet = parameters.Get<int>("@foo");
            }

            return iRet;
        }
    }
}
