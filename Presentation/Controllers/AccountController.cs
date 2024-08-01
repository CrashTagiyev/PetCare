using Application.ServiceAbstracts;
using Domain.Models.AuthModels.Request;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly IAuthService _authService;
		private readonly IHubService _hubService;

		public AccountController(IAuthService authService, IHubService hubService)
		{
			_authService = authService;
			_hubService = hubService;
		}



		[HttpPost("Login")]
		public async Task<IActionResult> LogIn(LoginRequest loginRequest)
		{
			var response = await _authService.Login(loginRequest, Response);
			return Ok(new { token = response.AccessToken, refreshToken = response.RefreshToken, message = response.StatusMessage, statusCode = response.StatusCode });
		}



		[HttpPost("RefreshToken")]
		public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest refreshTokenRequest)
		{
			await Console.Out.WriteLineAsync(refreshTokenRequest.RefreshToken);
			var response = await _authService.RefreshToken(refreshTokenRequest.RefreshToken);
			return Ok(new { accessToken = response.AccessToken, refreshToken = response.RefreshToken, message = response.StatusMessage });
		}



		[HttpPost("Register")]
		public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
		{
			if (!ModelState.IsValid)
			{
				var errors = ModelState
					 .Where(ms => ms.Value.Errors.Count > 0)
					 .ToDictionary(
							 ms => ms.Key,
							 ms => ms.Value.Errors.Select(e => e.ErrorMessage).ToArray());

				return BadRequest(new { errors });
			}

			var result = await _authService.Register(registerRequest);
			if (result.StatusCode != HttpStatusCode.OK)
			{
				return BadRequest(new { errors = result.StatusMessage });
			}

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


		[HttpGet("GetUsersChats")]
		public async Task<IActionResult> GetUsersChats([FromQuery]string userName)
		{
            Console.WriteLine(userName);
            var responseData = await _hubService.GetUsersChats(userName);
			return Ok(new { chats = responseData });
		}

	}
}
