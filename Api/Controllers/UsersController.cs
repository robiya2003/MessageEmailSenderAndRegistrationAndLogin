using Appliction.DTOS;
using Appliction.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetUsers());
        }
        [HttpGet]
        public IActionResult GetByUsername(string username)
        {
            return Ok(_userService.GetByUsername(username));
        }
        [HttpPost] public IActionResult Get(UserDTO userDTO)
        {
            return Ok(_userService.Registration(userDTO));
        }
    }
}
