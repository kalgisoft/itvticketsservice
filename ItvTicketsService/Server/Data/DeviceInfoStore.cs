using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Dapper;
using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ItvTicketsService.Shared.Models;

namespace ItvTicketsService.Server.Data
{
    public interface IDeviceInfoStore<TDeviceInfo> : IDisposable where TDeviceInfo : class
    {
        Task<int> DeviceInfoUpsert(TDeviceInfo devinfo);
        Task<TDeviceInfo> Device_GetInfoByCode(string code);
        Task<IdentityResult> DeviceInfoDelete(string code);
    }
    
    public class DeviceInfoStore : IDeviceInfoStore<DeviceInfo>
    {
        private readonly string _connectionString;

        public DeviceInfoStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
            //nothing to dispose
        }

        public async Task<int> DeviceInfoUpsert(DeviceInfo devinfo)
        {
            int iRet = -1; //error

            using (var conn = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("Code", devinfo.Code, DbType.String);
                parameters.Add("p1", devinfo.TipoMacchina, DbType.String);
                parameters.Add("p2", devinfo.SensoDiMarcia, DbType.String);
                parameters.Add("p3", devinfo.Matricola, DbType.String);
                parameters.Add("p4", devinfo.Cliente, DbType.String);
                parameters.Add("p5", devinfo.CommessaNr, DbType.String);
                parameters.Add("p6", devinfo.DataCollaudo, DbType.DateTime);
                parameters.Add("p7", devinfo.DataConsegna, DbType.DateTime);
                parameters.Add("p8", devinfo.CompilatoDa, DbType.String);
                parameters.Add("p9", devinfo.Data, DbType.DateTime);
                parameters.Add("p10", devinfo.TipoPC, DbType.String);
                parameters.Add("p11", devinfo.HardDisk, DbType.String);
                parameters.Add("p12", devinfo.RAM, DbType.String);
                parameters.Add("p13", devinfo.Grabber, DbType.String);
                parameters.Add("p14", devinfo.NumLed, DbType.Int32);
                parameters.Add("p15", devinfo.TipoLedD, DbType.String);
                parameters.Add("p16", devinfo.TipoLedN, DbType.String);
                parameters.Add("p17", devinfo.DistanzaIlluminatore, DbType.Int32);
                parameters.Add("p18", devinfo.Note1, DbType.String);
                parameters.Add("p19", devinfo.RealizzatoDa, DbType.String);
                parameters.Add("p20", devinfo.Data1, DbType.DateTime);
                parameters.Add("p21", devinfo.QuadroRealDa, DbType.String);
                parameters.Add("p22", devinfo.NumSchemaEl, DbType.Int32);
                parameters.Add("p23", devinfo.installRealDa, DbType.String);
                parameters.Add("p24", devinfo.GruppoCont, DbType.String);
                parameters.Add("p25", devinfo.CollaudoRealDa, DbType.String);
                parameters.Add("p26", devinfo.Condizionatore, DbType.String);
                parameters.Add("p27", devinfo.Note2, DbType.String);
                parameters.Add("p28", devinfo.VerSWTilevision, DbType.String);
                parameters.Add("p29", devinfo.VerSWCalibroPlanar, DbType.String);
                parameters.Add("p30", devinfo.NumSensPlanar, DbType.Int32);
                parameters.Add("p31", devinfo.TipoSens, DbType.String);
                parameters.Add("p32", devinfo.NoteAggiuntive, DbType.String);
                parameters.Add("p33", devinfo.NomePC, DbType.String);
                parameters.Add("p34", devinfo.TipoCinghia, DbType.String);
                parameters.Add("p35", devinfo.LargCinghia, DbType.String);
                parameters.Add("p36", devinfo.TipoMotori, DbType.String);
                parameters.Add("p37", devinfo.TipoRiduttori, DbType.String);
                parameters.Add("p38", devinfo.TipoMarcatura, DbType.String);
                parameters.Add("p39", devinfo.Centratore, DbType.String);
                parameters.Add("p40", devinfo.MotoreMovTraverse, DbType.String);
                parameters.Add("p41", devinfo.TipoEncoder, DbType.String);
                parameters.Add("p42", devinfo.TipoAzionamenti, DbType.String);
                parameters.Add("p43", devinfo.MassimoFormato, DbType.Int32);
                parameters.Add("p44", devinfo.MinimoFormato, DbType.Int32);
                parameters.Add("p45", devinfo.TipoMotoriTLC, DbType.String);
                parameters.Add("p46", devinfo.AltezzaTlcN, DbType.Int32);
                parameters.Add("p47", devinfo.TipoTlcN, DbType.String);
                parameters.Add("p48", devinfo.TipoTlcD, DbType.String);
                parameters.Add("p49", devinfo.TipoObjN, DbType.String);
                parameters.Add("p50", devinfo.TipoObjD, DbType.String);
                parameters.Add("p51", devinfo.AperturaObjN, DbType.String);
                parameters.Add("p52", devinfo.AperturaObjD, DbType.String);
                parameters.Add("p53", devinfo.Note3, DbType.String);
                parameters.Add("p54", devinfo.MontaggioDa, DbType.String);
                parameters.Add("p55", devinfo.Data2, DbType.DateTime);

                // Stored procedure method
                await conn.ExecuteAsync("spDeviceInfo_Upsert", parameters, commandType: CommandType.StoredProcedure);

                iRet = 0; //ok
            }

            return iRet;
        }

        public async Task<DeviceInfo> Device_GetInfoByCode(string code)
        {
            DeviceInfo devinfo = new DeviceInfo();

            using (var conn = new SqlConnection(_connectionString))
            {
                devinfo = await conn.QuerySingleOrDefaultAsync<DeviceInfo>($@"SELECT * FROM [DeviceInfo]
                    WHERE [Code] = @{nameof(code)}", new { code });
            }

            return devinfo;
        }

        public async Task<IdentityResult> DeviceInfoDelete(string code)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.QuerySingleOrDefaultAsync<DeviceInfo>($@"DELETE * FROM [DeviceInfo]
                    WHERE [Code] = @{nameof(code)}", new { code });
            }

            return IdentityResult.Success;
        }
    }
}
