using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Showroom.Data.Entities;
using Showroom.Infrastucture;
using Showroom.Infrastucture.Services;

namespace Showroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ICurrentUserService _currentUserService;

        public UserController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [HttpGet("getloggedinuserinfo")]
        public async Task<IActionResult> GetLoggedInUserInfo()
        {
            return Ok(await Task.FromResult(ResponseContext<User>.Success(new User
            {
                Username = this._currentUserService.Username,
                Email = this._currentUserService.Email,
                Firstname = this._currentUserService.Firstname,
                Lastname = this._currentUserService.Lastname,
                UserId = Convert.ToInt32(this._currentUserService.UserId)
            })));
        }
    }
}
