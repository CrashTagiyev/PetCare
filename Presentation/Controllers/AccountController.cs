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
	
			var response = await _authService.Login(loginRequest, Response);
			return Ok(new { token = response.AccessToken, refreshToken = response.RefreshToken, message = response.StatusMessage ,statusCode=response.StatusCode});
		}



		[HttpPost("RefreshToken")]
		public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest refreshTokenRequest)
		{
            await Console.Out.WriteLineAsync(refreshTokenRequest.RefreshToken);
            var response = await _authService.RefreshToken(refreshTokenRequest.RefreshToken);
			return Ok(new { accessToken = response.AccessToken,refreshToken=response.RefreshToken, message = response.StatusMessage });
		}



		[HttpPost("Register")]
		public async Task<IActionResult> Register(RegisterRequest registerRequest)
		{
			if (!ModelState.IsValid)
				return NotFound(registerRequest);

			var result = await _authService.Register(registerRequest);
			return Ok(new { statusCode = result.StatusCode, statusMessage = result.StatusMessage });
		}


		[HttpGet("ConfirmEmail")]
		public async Task<IActionResult> ConfirmEmail([FromQuery] int userId, [FromQuery] string token)
		{
			var response = await _authService.ConfirmEmail(userId, token);
			return Ok(response);
		}

		[HttpPost("ForgotPassword")]
		public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
		{
			var response = await _authService.ForgotPassword(request);
			return Ok(new { statusMessage = response.StatusMessage, statusCode = response.StatusCode, token = response.Token, userId = response.UserId });
		}

		[HttpPost("ResetPassword")]
		public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
		{
			var response = await _authService.ResetPassword(request);
			return Ok(new { statusMessage = response.StatusMessage, statusCode = response.StatusCode });
		}

	}
}
