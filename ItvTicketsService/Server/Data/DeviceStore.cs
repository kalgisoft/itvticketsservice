using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ItvTicketsService.Shared.Models;

namespace ItvTicketsService.Server.Data
{
    public interface IDeviceStore<TDevice> : IDisposable where TDevice : class
    {
        Task<int> DeviceInsert(TDevice device);
        Task<List<TDevice>> DeviceList();
        Task<TDevice> Device_GetOne(int Id);
        Task<IdentityResult> DeviceUpdate(TDevice device);
        Task<IdentityResult> DeviceDelete(int Id);
        Task<List<TDevice>> DevicesForPlant(int plantId);
    }

    public class DeviceStore : IDeviceStore<Device>
    {
        private readonly string _connectionString;

        public DeviceStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
            //nothing to dispose
        }

        public async Task<IdentityResult> DeviceDelete(int Id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync("spDevice_Delete", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<int> DeviceInsert(Device device)
        {
            int iRet = -1;

            if (device == null)
            {
                throw new ArgumentNullException("Device null data");
            }

            if (string.IsNullOrEmpty(device.Code))
            {
                throw new ArgumentNullException(nameof(device.Code));
            }

            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Code", device.Code, DbType.String);
                parameters.Add("Type", device.Type, DbType.String);
                parameters.Add("Info", device.Info, DbType.String);
                parameters.Add("PlantId", device.PlantId, DbType.Int32);
                parameters.Add("NumLinea", device.NumLinea, DbType.Int32);
                parameters.Add("IdContractor", device.IdContractor, DbType.Int32);

                parameters.Add("@foo", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                // Stored procedure method
                await conn.ExecuteAsync("spDevice_Insert", parameters, commandType: CommandType.StoredProcedure);

                iRet = parameters.Get<int>("@foo");
            }

            return iRet;
        }

        public async Task<IdentityResult> DeviceUpdate(Device device)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", device.Id, DbType.String);
                parameters.Add("Code", device.Code, DbType.String);
                parameters.Add("Type", device.Type, DbType.String);
                parameters.Add("Info", device.Info, DbType.String);
                parameters.Add("PlantId", device.PlantId, DbType.Int32);
                parameters.Add("NumLinea", device.NumLinea, DbType.Int32);
                parameters.Add("IdContractor", device.IdContractor, DbType.Int32);

                await conn.ExecuteAsync("spDevice_Update", parameters, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<Device> Device_GetOne(int Id)
        {
            Device device = new Device();
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Id, DbType.Int32);
            using (var conn = new SqlConnection(_connectionString))
            {
                device = await conn.QueryFirstOrDefaultAsync<Device>("spDevice_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }

            return device;
        }

        public async Task<List<Device>> DeviceList()
        {
            IEnumerable<Device> devices;
            using (var conn = new SqlConnection(_connectionString))
            {
                devices = await conn.QueryAsync<Device>("spDevice_List", commandType: CommandType.StoredProcedure);
            }

            return devices.ToList();
        }

        public async Task<List<Device>> DevicesForPlant(int plantId)
        {
            IEnumerable<Device> devices;
            using (var conn = new SqlConnection(_connectionString))
            {
                string sql = "Select * from Devices where PlantId = " + plantId.ToString();
                devices = await conn.QueryAsync<Device>(sql);
            }

            return devices.ToList();
        }
    }
}
