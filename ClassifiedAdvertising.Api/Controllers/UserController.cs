using ClassifiedAdvertising.Service.Dtos;
using ClassifiedAdvertising.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser([FromRoute]int id)
        {
            var user = await _userService.GetUserByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody]CreateUserDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _userService.CreateUserAsync(user);

            return Ok(result);
        }
    }
}