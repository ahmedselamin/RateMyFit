using Microsoft.AspNetCore.Mvc;
using RateMyFit.Server.Services.AuthService;

namespace RateMyFit.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request)
        {
            var response = await _authService.Register(
                new User
                {
                    Email = request.Email
                },
                request.Password);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
    }
}
