using Application.AbstractServices;
using Domain.Models.AuthModels.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
		
			//await Console.Out.WriteLineAsync("-------------------------------");
			//await Console.Out.WriteLineAsync(loginRequest.EmailAddress);
			//await Console.Out.WriteLineAsync(loginRequest.Password);
			//await Console.Out.WriteLineAsync("-------------------------------");
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
			//await Console.Out.WriteLineAsync("---------------------------");
			//await Console.Out.WriteLineAsync(registerRequest.UserName);
			//await Console.Out.WriteLineAsync(registerRequest.Email);
			//await Console.Out.WriteLineAsync(registerRequest.Password);
			//await Console.Out.WriteLineAsync(registerRequest.Firstname);
			//await Console.Out.WriteLineAsync(registerRequest.Lastname);
			//await Console.Out.WriteLineAsync(registerRequest.DateOfBirth.ToString());
			//await Console.Out.WriteLineAsync(registerRequest.City);
			//await Console.Out.WriteLineAsync(registerRequest.Address);
			//await Console.Out.WriteLineAsync("-------------------------");

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
            await Console.Out.WriteLineAsync("-------------------------------");
            await Console.Out.WriteLineAsync(request.Email);
            await Console.Out.WriteLineAsync("-------------------------------");
            var response = await _authService.ForgotPassword(request);
			return Ok(new { statusMessage = response.StatusMessage, statusCode = response.StatusCode, token = response.Token, userId = response.UserId });
		}
		
		[HttpPost("ResetPassword")]
		public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
		{
            await Console.Out.WriteLineAsync("----------------------------");
            await Console.Out.WriteLineAsync(request.Token);
            await Console.Out.WriteLineAsync(request.UserId.ToString());
            await Console.Out.WriteLineAsync(request.NewPassword);
            await Console.Out.WriteLineAsync("---------------------------- ");

			var response = await _authService.ResetPassword(request);
			return Ok(new { statusMessage = response.StatusMessage, statusCode = response.StatusCode });
		}

	}
}
