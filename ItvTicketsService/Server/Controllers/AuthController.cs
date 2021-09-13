using ItvTicketsService.Server.Data;
using ItvTicketsService.Server.Models;
using ItvTicketsService.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Controllers
{
    /// <summary>
    /// used with Login, Register and to get current user's information
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogStore<Log> _logManager;
        private readonly IConfigurationSection _jwtSettings;
        private readonly IConfiguration _configuration;
        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogStore<Log> logManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logManager = logManager;
            _configuration = configuration;
            _jwtSettings = _configuration.GetSection("JwtSettings");
        }

        /// <summary>
        /// Check user credentials and validate.
        /// If validated true then send success else send badrequest with message
        /// </summary>
        /// <param name="request">Username and Password</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(UserForAuthenticationDto request)
        {
            Log lg = new Log();
            lg.CreatedDate = DateTime.Now.ToString();

            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                lg.LogLevel = "Error";
                lg.ExceptionMessage = "Login Username Error Username=" + request.UserName;
                await _logManager.LogInsert(lg);

                return Unauthorized(new AuthResponseDto { ErrorMessage = "User does not exist" });
            }

            var singInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!singInResult.Succeeded)
            {
                lg.LogLevel = "Error";
                lg.ExceptionMessage = "Login Password Error for Username=" + request.UserName;
                await _logManager.LogInsert(lg);

                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });
            }
            //await _signInManager.SignInAsync(user, request.RememberMe);

            //log 
            lg.UserId = user.Id;
            lg.LogLevel = "Information";
            lg.ExceptionMessage = "Login user=" + user.UserName;
            await _logManager.LogInsert(lg);

            var signingCredentials = GetSigningCredentials();
            var claims = GetClaims(user);
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtSettings["securityKey"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private List<Claim> GetClaims(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };
            var roles = _userManager.GetRolesAsync(user).Result;
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings["expiryInMinutes"])),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }

        /// <summary>
        /// Post method to create new users.
        /// If validated true then send success else send badrequest with message
        /// </summary>
        /// <param name="parameters">Users detail</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest parameters)
        {
            var user = new ApplicationUser();
            user.UserName = parameters.UserName;
            user.PlantId = parameters.PlantId;
            var result = await _userManager.CreateAsync(user, parameters.Password);
            if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);

            Log lg = new Log();
            lg.CreatedDate = DateTime.Now.ToString();
            lg.UserId = user.Id;
            lg.LogLevel = "Information";
            lg.ExceptionMessage = "Added User Username=" + user.UserName;
            await _logManager.LogInsert(lg);

            return Ok();
            //return await Login(new LoginRequest
            //{
            //    UserName = parameters.UserName,
            //    Password = parameters.Password
            //});
        }
        
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            //log
            Log lg = new Log();
            lg.CreatedDate = DateTime.Now.ToString();
            //lg.UserId = CurrentUser.
            lg.LogLevel = "Information";
            lg.ExceptionMessage = "Logout user=" + User.Identity.Name;
            await _logManager.LogInsert(lg);

            return Ok();
        }

        /// <summary>
        /// Get logged-in users information
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<CurrentUser> CurrentUserInfo()
        {
            var claimsIdentity = User.Identity as System.Security.Claims.ClaimsIdentity;
            if (User != null && User.Identity != null && User.Identity.Name != null)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                return new CurrentUser
                {
                    IsAuthenticated = User.Identity.IsAuthenticated,
                    UserName = User.Identity.Name,
                    Role = claimsIdentity.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => (RoleType)Enum.Parse(typeof(RoleType), x.Value)).ToList(),
                    Claims = User.Claims.ToDictionary(c => c.Type, c => c.Value),
                    //PlantId = User.IsInRole(RoleType.Admin.ToString()) == false ? user.PlantId : 0
                    PlantId = user.PlantId,
                    UserId = user.Id
                };
            }
            else
            {
                return new CurrentUser();
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<List<ApplicationUser>> GetUsers()
        {
            string role = "admin";
            var users = await _userManager.GetUsersInRoleAsync(role);

            return users.ToList();
        }
    }
}