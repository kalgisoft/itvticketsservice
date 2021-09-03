using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using ItvTicketsService.Shared.Models;
using System.Data;

namespace ItvTicketsService.Server.Data
{
    public interface ITicketsStore<TTicket> : IDisposable where TTicket : class
    {
        Task<IdentityResult> CreateAsync(TTicket ticket);

        Task<IdentityResult> DeleteAsync(TTicket ticket);

        Task<IdentityResult> UpdateAsync(TTicket ticket);
        Task<List<TTicket>> FindByPlantIdAsync(int id, bool fullList);
        Task<TTicket> FindTicketByIdAsync(int id);
        Task<List<TTicket>> FindTicketsByDevCode(string code);
        Task<List<TTicket>> FindTicketsByClientId(int id);
        Task<List<TTicket>> FindTicketsByDateInterval(string from, string to);
        Task<List<TicketStatusModel>> GetTicketStatuses();
    }

    public class TicketsStore : ITicketsStore<Tickets>
    {
        private readonly string _connectionString;

        public TicketsStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IdentityResult> CreateAsync(Tickets ticket)
        {
            if (string.IsNullOrEmpty(ticket.Reason))
            {
                throw new ArgumentNullException(nameof(ticket.Reason));
            }
            /*
            if (string.IsNullOrEmpty(ticket.CompanyName))
            {
                throw new ArgumentNullException(nameof(ticket.CompanyName));
            }
            */

            ticket.CreatedDate = System.DateTime.Now;
            ticket.OpenDate = ticket.CreatedDate;
            ticket.CloseDate = ticket.CreatedDate;

            ticket.TicketStatusId = 1;

            using (var connection = new SqlConnection(_connectionString))
            {
                //await connection.OpenAsync(cancellationToken);
                ticket.TicketId = await connection.QuerySingleAsync<int>($@"INSERT INTO [Tickets] ([CreatedDate],[OpenDate],[CloseDate],[Reason],[ClientId],[TeamId],[DeviceId],[TicketStatusId],[CloserId])
                    VALUES (@{nameof(Tickets.CreatedDate)}, @{nameof(Tickets.OpenDate)}, @{nameof(Tickets.CloseDate)}, @{nameof(Tickets.Reason)}, @{nameof(Tickets.ClientId)}, @{nameof(Tickets.TeamId)}, @{nameof(Tickets.DeviceId)}, @{nameof(Tickets.TicketStatusId)}, @{nameof(Tickets.CloserId)});
                    SELECT CAST(SCOPE_IDENTITY() as int)", ticket);
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> UpdateAsync(Tickets ticket)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync($@"UPDATE [Tickets] SET
                    [OpenDate] = @{nameof(Tickets.OpenDate)},
                    [CloseDate] = @{nameof(Tickets.CloseDate)},
                    [teamId] = @{nameof(Tickets.TeamId)},
                    [Reason] = @{nameof(Tickets.Reason)},
                    [TeamMemo] = @{nameof(Tickets.TeamMemo)},
                    [TicketStatusId] = @{nameof(Tickets.TicketStatusId)},
                    [CloserId] = @{nameof(Tickets.CloserId)}
                    WHERE [TicketId] = @{nameof(Tickets.TicketId)}", ticket);
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteAsync(Tickets ticket)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync($"DELETE FROM [Tickets] WHERE [TicketId] = @{nameof(Tickets.TicketId)}", ticket);
            }

            return IdentityResult.Success;
        }

        public async Task<List<Tickets>> FindByPlantIdAsync(int id, bool fullList)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                if (fullList)
                {
                    return (await connection.QueryAsync<Tickets>($@"SELECT * FROM TICKETS T 
                    INNER JOIN TicketStatusMaster TS ON TS.TicketStatusId = T.TicketStatusId
                    ORDER BY CreatedDate DESC")).ToList();
                }
                else
                {
                    return (await connection.QueryAsync<Tickets>($@"SELECT * FROM TICKETS T 
                    INNER JOIN TicketStatusMaster TS ON TS.TicketStatusId = T.TicketStatusId
                    WHERE T.ClientId = {id} ORDER BY CreatedDate DESC")).ToList();
                }                
            }
        }

        public async Task<Tickets> FindTicketByIdAsync(int Id)
        {
            Tickets tk = new Tickets();
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                tk = await conn.QueryFirstOrDefaultAsync<Tickets>("spTicket_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            
            return tk;
        }
        
	
        public async Task<List<Tickets>> FindTicketsByDevCode(string code)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                //string sql = $@"SELECT * FROM [Tickets] WHERE [DeviceId] = (SELECT Top 1 Id From [Devices] where Code='{code}')";

                string sql = $@"SELECT * FROM TICKETS T 
                    INNER JOIN TicketStatusMaster TS ON TS.TicketStatusId = T.TicketStatusId
                    WHERE T.DeviceId = (SELECT Top 1 Id From [Devices] where Code='{code}') ORDER BY CreatedDate DESC";

                return (await connection.QueryAsync<Tickets>(sql)).ToList();
            }
        }

        public async Task<List<Tickets>> FindTicketsByClientId(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
               // string sql = $@"SELECT * FROM [Tickets] WHERE [ClientId] = '{id}'";
                
                string sql = $@"SELECT * FROM TICKETS T 
                    INNER JOIN TicketStatusMaster TS ON TS.TicketStatusId = T.TicketStatusId
                    WHERE T.ClientId = '{id}' ORDER BY CreatedDate DESC";

                return (await connection.QueryAsync<Tickets>(sql)).ToList();
            }
        }

        public async Task<List<Tickets>> FindTicketsByPlantId(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = $@"SELECT * FROM [Tickets] WHERE [ClientId] = (SELECT Top 1 Id From [ApplicationUser] where PlantId='{id}')";
                return (await connection.QueryAsync<Tickets>(sql)).ToList();
            }
        }

        public async Task<List<Tickets>> FindTicketsByDateInterval(string tStart, string tEnd)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                //string sql = $@"SELECT * FROM [Tickets] WHERE [CreatedDate] >= '{tStart}' AND [CreatedDate] <= '{tEnd} 23:59:59'";
                string sql = $@"SELECT * FROM TICKETS T
                    INNER JOIN TicketStatusMaster TS ON TS.TicketStatusId = T.TicketStatusId
                    WHERE T.CreatedDate >= '{tStart}' AND T.CreatedDate <= '{tEnd} 23:59:59' ORDER BY CreatedDate DESC";

                return (await connection.QueryAsync<Tickets>(sql)).ToList();
            }
        }

        public async Task<List<TicketStatusModel>> GetTicketStatuses()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (await connection.QueryAsync<TicketStatusModel>($@"SELECT * FROM [TicketStatusMaster]
                    WHERE [IsDeleted] = 0")).ToList();
            }
        }

        public void Dispose()
        {
            // Nothing to dispose.
        }
    }
}
