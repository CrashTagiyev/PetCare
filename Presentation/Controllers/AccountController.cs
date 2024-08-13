using Application.ServiceAbstracts;
using Domain.Identity;
using Domain.Models.AuthModels.Request;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
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
		private readonly UserManager<AppUser> _userManager;
		private readonly IValidator<LoginRequest> _loginRequestValidato;

		public AccountController(IAuthService authService, IHubService hubService, UserManager<AppUser> userManager, IValidator<LoginRequest> loginRequestValidato)
		{
			_authService = authService;
			_hubService = hubService;
			_userManager = userManager;
			_loginRequestValidato = loginRequestValidato;
		}



		[HttpPost("Login")]
		public async Task<IActionResult> LogIn([FromBody] LoginRequest loginRequest)
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

			var response = await _authService.Login(loginRequest);
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

		public async Task<IActionResult> Register([FromForm] RegisterRequest registerRequest)
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

			// Proceed with registration
			var result = await _authService.Register(registerRequest);
			if (result.StatusCode != HttpStatusCode.OK)
			{
				// Handle other errors here if necessary
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
			if (!ModelState.IsValid)
			{
				var errors = ModelState
					.Where(ms => ms.Value.Errors.Count > 0)
					.ToDictionary(
						ms => ms.Key,
						ms => ms.Value.Errors.Select(e => e.ErrorMessage).ToArray());

				return BadRequest(new { errors });

			}

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
		public async Task<IActionResult> GetUsersChats([FromQuery] string userName)
		{
			try
			{

				var responseData = await _hubService.GetUsersChats(userName);
				return Ok(new { chats = responseData });
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		[HttpGet("GetChatsMessages")]
		public async Task<IActionResult> GetChatsMessages([FromQuery] string username, [FromQuery] string chatName)
		{

			Console.WriteLine(chatName);
			var responseData = await _hubService.GetChatsMessages(username, chatName);
			return Ok(new { messages = responseData.ToList() });
		}
	}
}
