using ItvTicketsService.Server.Data;
using ItvTicketsService.Server.Models;
using ItvTicketsService.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogStore<Log> logManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logManager = logManager;
        }

        /// <summary>
        /// Check user credentials and validate.
        /// If validated true then send success else send badrequest with message
        /// </summary>
        /// <param name="request">Username and Password</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            Log lg = new Log();
            lg.CreatedDate = DateTime.Now.ToString();

            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                lg.LogLevel = "Error";
                lg.ExceptionMessage = "Login Username Error Username=" + request.UserName;
                await _logManager.LogInsert(lg);

                return BadRequest("User does not exist");
            } 

            var singInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!singInResult.Succeeded)
            {
                lg.LogLevel = "Error";
                lg.ExceptionMessage = "Login Password Error for Username=" + request.UserName;
                await _logManager.LogInsert(lg);

                return BadRequest("Invalid password");
            } 
            await _signInManager.SignInAsync(user, request.RememberMe);

            //log 
            lg.UserId = user.Id;
            lg.LogLevel = "Information";
            lg.ExceptionMessage = "Login user=" + user.UserName;
            await _logManager.LogInsert(lg);

            return Ok();
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
            lg.ExceptionMessage = "Added User Username="+user.UserName;
            await _logManager.LogInsert(lg);

            return Ok();
            //return await Login(new LoginRequest
            //{
            //    UserName = parameters.UserName,
            //    Password = parameters.Password
            //});
        }
        [Authorize]
        [HttpPost]
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
        public async Task<List<ApplicationUser>> GetUsers()
        {
            string role = "admin";
            var users = await _userManager.GetUsersInRoleAsync(role);

            return users.ToList();
        }
    }
}