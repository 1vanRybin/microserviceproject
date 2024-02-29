using Logic.Users.Interfaces;
using Logic.Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserLogicManager _userLogicManager;

        public UserController(IUserLogicManager userLogicManager)
        {
            _userLogicManager = userLogicManager;
        }

        [HttpPost]
        public async Task<ActionResult> CreateUserAsync([FromBody] UserLogic user)
        {
            if(await _userLogicManager.CreateUserAsync(user))
            {
                return Ok("User created.");
            }
            return BadRequest("User didn't create.");
        }

        [HttpGet]
        public async Task<ActionResult<UserLogic>> GetUserAsync([FromBody] Guid userId)
        {
            return Ok(await _userLogicManager.GetUserByIdAsync(userId));
        }
    }
}
