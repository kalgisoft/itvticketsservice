using ItvTicketsService.Shared.Models;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDto> Login(UserForAuthenticationDto loginRequest);
        Task Register(RegisterRequest registerRequest);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
    }
}
