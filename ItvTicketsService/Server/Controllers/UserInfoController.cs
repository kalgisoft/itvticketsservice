using ItvTicketsService.Server.Data;
using ItvTicketsService.Server.Models;
using ItvTicketsService.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfoStore<UserInfo> _userinfoStore;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogStore<Log> _logManager;
        public UserInfoController(IUserInfoStore<UserInfo> userinfoStore, UserManager<ApplicationUser> userManager, ILogStore<Log> logManager)
        {
            _userinfoStore = userinfoStore;
            _userManager = userManager;
            _logManager = logManager;
        }

        //Get Users List
        [HttpGet("{idRole:int}")]
        public async Task<ActionResult<List<UserInfo>>> GetUsers(int idRole)
        {
            try
            {
                return Ok(await _userinfoStore.UserInfoList(idRole));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        //Get UserInfo by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<UserInfo>> Users_GetOne(int id)
        {
            try
            {
                var result = await _userinfoStore.UserInfo_GetOne(id);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                string sss = ex.Message;

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> Users_Upsert(List<int> param)
        {
            try
            {
                if (param[0] == 0)
                {
                    return BadRequest();
                }

                int newInsert = await _userinfoStore.UserInfo_Upsert(param[0], param[1]);
                return Ok(newInsert);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Users_ResetPassword(UserInfo user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var applicationUser = new ApplicationUser();
            applicationUser.Id = user.Id;
            applicationUser.UserName = user.UserName;
            applicationUser.PlantId = 1;
            string code = await _userManager.GeneratePasswordResetTokenAsync(applicationUser);
            var result = await _userManager.ResetPasswordAsync(applicationUser, code, user.Password);
            if (result.Succeeded == false)
            {
                return BadRequest(result.Errors.FirstOrDefault()?.Description);
            }

            Log lg = new Log();
            lg.CreatedDate = DateTime.Now.ToString();
            lg.UserId = user.Id;
            lg.LogLevel = "Information";
            lg.ExceptionMessage = "Password reset for Username=" + user.UserName;
            await _logManager.LogInsert(lg);

            return Ok();
        }


        [HttpDelete("{userid:int}/{plantid:int}")]
        public async Task<ActionResult<UserInfo>> Users_Delete(int userid, int plantid)
        {
            try
            {
                var ToDelete = await _userinfoStore.UserInfo_GetOne(userid);
                if (ToDelete == null)
                {
                    return NotFound($"Plant with Id={plantid} not found");
                }
                var result = await _userinfoStore.UserInfo_Delete(userid, plantid);

                return Ok(ToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpDelete("{userid:int}")]
        public async Task<ActionResult<UserInfo>> Users_DeleteAll(int userid)
        {
            try
            {
                var ToDelete = await _userinfoStore.UserInfo_GetOne(userid);
                if (ToDelete == null)
                {
                    return NotFound($"Client with Id={userid} not found");
                }
                var result = await _userinfoStore.UserInfo_DeleteAll(userid);

                return Ok(ToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpGet("{idUser:int}/{idRole:int}")]
        public async Task<ActionResult<bool>> Users_ChangeRole(int idUser, int idRole)
        {
            try
            {
                return Ok(await _userinfoStore.UserInfo_ChangeRole(idUser, idRole));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

    }
}
