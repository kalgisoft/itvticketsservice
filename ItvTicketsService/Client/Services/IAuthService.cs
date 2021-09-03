using ItvTicketsService.Shared.Models;
using System.Threading.Tasks;

namespace ItvTicketsService.Client.Services
{
    public interface IAuthService
    {
        Task Login(LoginRequest loginRequest);
        Task Register(RegisterRequest registerRequest);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
    }
}
