using ClassifiedAdvertising.Service.Dtos;
using ClassifiedAdvertising.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassifiedAdvertising.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterAsync(CreateUserDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var errors = await _authenticationService.RegisterUserAsync(user);

            if (errors?.Count > 0)
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Key, error.Value);
                }
                return BadRequest(errors);
            }
            return Ok();
        }
    }
}