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
		private readonly IEmailService _emailService;
		
		public AccountController(IAuthService authService, IEmailService emailService)
		{
			_authService = authService;
			_emailService = emailService;
		}

		[HttpPost("Login")]
		public async Task<IActionResult> LogIn(LoginRequest loginRequest)
		{
			var accessToken = await _authService.Login(loginRequest, Response);
			return Ok(new { token = accessToken.AccessToken,message=accessToken.StatusMessage });
		}

		[HttpPost("Refresh")]
		public async Task<IActionResult> Refresh(LoginRequest loginRequest)
		{
			var acceccToken = await _authService.RefreshToken(Request,Response);
			return Ok(new { accessToken = acceccToken.AccessToken, message = acceccToken.StatusMessage });
		}

		[HttpPost("Register")]
		public async Task<IActionResult> Register(RegisterRequest registerRequest)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var result  = await _authService.Register(registerRequest);
			return Ok(result);
		}
	}
}
