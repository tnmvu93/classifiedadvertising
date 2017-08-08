using ClassifiedAdvertising.Service.Dtos;
using ClassifiedAdvertising.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;

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
        public async Task<IActionResult> RegisterAsync([FromBody]CreateUserDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var errors = await _authenticationService.RegisterUserAsync(user);
                if (errors.Count > 0)
                {
                    return BadRequest(errors);
                }
            }
            catch (Exception e)
            {
                var test = e;
            }

            return Ok();
        }
    }
}