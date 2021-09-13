using Blazored.LocalStorage;
using ItvTicketsService.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    /// <summary>
    /// Contains method used with Login, Register flow
    /// </summary>
    public class AuthService : IAuthService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient client, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }

        /// <summary>
        /// Get current users information
        /// </summary>
        /// <returns></returns>
        public async Task<CurrentUser> CurrentUserInfo()
        {
            var result = await _client.GetFromJsonAsync<CurrentUser>("api/auth/currentuserinfo");
            return result;
        }

        /// <summary>
        /// Login to system
        /// </summary>
        /// <param name="loginRequest">Username and password</param>
        /// <returns></returns>
        public async Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication)
        {
            var content = JsonSerializer.Serialize(userForAuthentication);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var authResult = await _client.PostAsync("api/auth/login", bodyContent);
            var authContent = await authResult.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<AuthResponseDto>(authContent, _options);
            if (!authResult.IsSuccessStatusCode)
                return result;
            await _localStorage.SetItemAsync("authToken", result.Token);
            ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(result.Token);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);
            return new AuthResponseDto { IsAuthSuccessful = true };

            //var result = await _client.PostAsJsonAsync("api/auth/login", loginRequest);
            //if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            ////result.EnsureSuccessStatusCode();
            //return new AuthResponseDto { IsAuthSuccessful = true };
        }

        /// <summary>
        /// Logout from system
        /// </summary>
        /// <returns></returns>
        public async Task Logout()
        {
            var result = await _client.PostAsync("api/auth/logout", null);
            await _localStorage.RemoveItemAsync("authToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }

        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="registerRequest">Details of user to register</param>
        /// <returns></returns>
        public async Task Register(RegisterRequest registerRequest)
        {
            var result = await _client.PostAsJsonAsync("api/auth/register", registerRequest);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }
    }
}
