using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    interface IUserInfoService
    {
        Task<List<UserInfo>> GetUserList(int roleId);
        Task<UserInfo> UserInfo_GetOne(int id);

        Task<ResetPasswordInfo> GetResetPasswordInfo(int id);

        Task<HttpResponseMessage> UserInfo_DeleteAll(int clientid);
        Task<HttpResponseMessage> UserInfo_Delete(int clientid, int plantid);

        Task<int> UserInfo_Upsert(int clientid, int plantid);
        Task<bool> UserInfo_ChangeRole(int clientid, int newRole);

        Task UserInfo_ResetPassword(ResetPasswordInfo resetPasswordInfo);
    }
}
