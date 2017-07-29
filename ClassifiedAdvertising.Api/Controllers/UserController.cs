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
        public ActionResult GetUser([FromRoute]int id)
        {
            var user = _userService.GetUserById(id);

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

            await _userService.CreateUser(user);

            return Ok();
        }
    }
}