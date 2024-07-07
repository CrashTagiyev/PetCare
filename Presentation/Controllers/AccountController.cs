using Application.AbstractServices;
using Domain.Models.AuthModels.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AccountController(IAuthService authService)
		{
			_authService = authService;
		}



		[HttpPost("Login")]
		public async Task<IActionResult> LogIn(LoginRequest loginRequest)
		{
			var accessToken = await _authService.Login(loginRequest, Response);
			return Ok(new { token = accessToken.AccessToken, message = accessToken.StatusMessage });
		}



		[HttpPost("Refresh")]
		public async Task<IActionResult> Refresh(LoginRequest loginRequest)
		{
			var acceccToken = await _authService.RefreshToken(Request, Response);
			return Ok(new { accessToken = acceccToken.AccessToken, message = acceccToken.StatusMessage });
		}



		[HttpPost("Register")]
		public async Task<IActionResult> Register(RegisterRequest registerRequest)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var result = await _authService.Register(registerRequest);
			return Ok(result);
		}


		[HttpGet("COnfirmEmail")]
		public async Task<IActionResult> ConfirmEmail([FromQuery] int userId, [FromQuery] string token)
		{
			var response = await _authService.ConfirmEmail(userId,token);
			return Ok(response);
		}

	}
}
