using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementSystem.Application.ApplicationServices.Authentication;
using UniversityManagementSystem.Data.Models.Authentication;

namespace UniversityManagementSystem.BlazorWASM.Server.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationServiceAsync _authenticationService;
        public AuthenticationController(IAuthenticationServiceAsync _authenticationService)
        {
            this._authenticationService = _authenticationService;
        }
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] UserAuthDetailsModel authModel)
        {
            return Ok(await _authenticationService.AuthenticateAsync(authModel));
        }
    }
}
