using ItvTicketsService.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;

        public CurrentUser LoggedInUser { get; set; }

        public UserInfoService(HttpClient httpClient, IAuthService authService)
        {
            _httpClient = httpClient;
            _authService = authService;
        }

        public async Task<List<UserInfo>> GetUserList(int roleId)
        {
             return await _httpClient.GetFromJsonAsync<List<UserInfo>>("api/UserInfo/GetUsers/" + roleId.ToString());
        }

        public async Task<ResetPasswordInfo> GetResetPasswordInfo(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResetPasswordInfo>("api/UserInfo/GetResetPasswordInfo/" + id.ToString()); ;
        }

        public async Task<UserInfo> UserInfo_GetOne(int id)
        {
            return await _httpClient.GetFromJsonAsync<UserInfo>("api/UserInfo/Users_GetOne/" + id.ToString()); ;
        }

        public async Task<HttpResponseMessage> UserInfo_Delete(int clientid, int plantid)
        {
            return await _httpClient.DeleteAsync("api/UserInfo/Users_Delete/" + clientid.ToString() + "/" + plantid.ToString());
        }

        public async Task<HttpResponseMessage> UserInfo_DeleteAll(int clientid)
        {
            return await _httpClient.DeleteAsync("api/UserInfo/Users_DeleteAll/" + clientid.ToString());
        }

        public async Task<int> UserInfo_Upsert(int clientid, int plantid)
        {
            var result = await _httpClient.PostAsJsonAsync("api/UserInfo/Users_Upsert/", new List<int> {clientid, plantid});
            return await result.Content.ReadFromJsonAsync<int>();
        }

        public async Task<bool> UserInfo_ChangeRole(int clientid, int newRole)
        {
            return await _httpClient.GetFromJsonAsync<bool>("api/UserInfo/Users_ChangeRole/" + clientid.ToString() + @"/" + newRole.ToString());

            //return false;
        }

        public async Task UserInfo_ResetPassword(ResetPasswordInfo resetPasswordInfo)
        {
            var result = await _httpClient.PostAsJsonAsync("api/UserInfo/Users_ResetPassword/", resetPasswordInfo);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
            { 
                throw new Exception(await result.Content.ReadAsStringAsync()); 
            }
            result.EnsureSuccessStatusCode();

            //return false;
        }
    }
}
