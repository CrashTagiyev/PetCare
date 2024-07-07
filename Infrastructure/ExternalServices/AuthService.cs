using Application.AbstractServices;
using Azure.Core;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.TokenDTOs;
using Domain.Identity;
using Domain.Models.AuthModels.Request;
using Domain.Models.AuthModels.Response;
using Infrastructure.HelperMethods.Extenstions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Security.Claims;

namespace Infrastructure.ExternalServices
{
	public class AuthService : IAuthService
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly ITokenService _tokenService;
		private readonly IEmailService _emailService;
		private readonly IConfiguration _configuration;
		private readonly IAppUserReadRepository _appUserReadRepository;
		public AuthService(UserManager<AppUser> myUserManager, ITokenService tokenService, IEmailService emailService, IConfiguration configuration,  IAppUserReadRepository appUserReadRepository)
		{
			_userManager = myUserManager;
			_tokenService = tokenService;
			_emailService = emailService;
			_configuration = configuration;
			_appUserReadRepository = appUserReadRepository;
		}

		public async Task<LoginResponse> Login(LoginRequest dto,HttpResponse response)
		{
			var user = await _userManager.FindByEmailAsync(dto.EmailAddress);
			if (user is null)
				return new LoginResponse()
				{
					StatusCode = HttpStatusCode.NotFound,
					StatusMessage = "Incorrect email or password",
				};
			
			if (!user.EmailConfirmed)
				return new LoginResponse()
				{
					StatusMessage = "Email is not confirmed",
					StatusCode = HttpStatusCode.BadRequest
				};

			var result = await _userManager.CheckPasswordAsync(user, dto.PasswordHash);
			if (!result)
				return new LoginResponse()
				{
					StatusCode = HttpStatusCode.BadRequest,
					StatusMessage = "Incorrect email or password",
				};

			var roles = await _userManager.GetRolesAsync(user);
			var tokenRequestDto = new TokenRequestDTO
			{
				Email = dto.EmailAddress,
				Id = user.Id,
				UserName = user.UserName!,
				Roles = roles.ToList(),
				Claims = new List<Claim>
				{
					new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
					new Claim(ClaimTypes.Email, dto.EmailAddress),
					new Claim(ClaimTypes.Name, user.UserName!),
					new Claim(ClaimTypes.Role, string.Join(",", roles.ToList()))
				}
			};

			var accessToken = _tokenService.GenerateAccessToken(tokenRequestDto);
			var refreshToken = _tokenService.GenerateRefreshToken();

			_userManager.SetRefreshToken(user, refreshToken, response);

			return new LoginResponse
			{
				AccessToken = accessToken,
				RefreshToken=refreshToken.Token,
				StatusCode = HttpStatusCode.OK
			};
		}

		public async Task<LoginResponse> RefreshToken(HttpRequest request,HttpResponse response)
		{
			var refreshToken = request.Cookies["refreshToken"];
			if (string.IsNullOrEmpty(refreshToken))
				return new LoginResponse { StatusCode = HttpStatusCode.Forbidden, StatusMessage = "Invalid refresh token" };

			var user = await _appUserReadRepository.FinByRefreshToken(refreshToken);
			if (user is null)
				return new LoginResponse { StatusCode = HttpStatusCode.Forbidden, StatusMessage = "Invalid refresh token,User did with this refresh token did not found" };


			if (user.RefreshTokenExpireTime <DateTime.Now)
			return new LoginResponse { StatusCode = HttpStatusCode.Forbidden, StatusMessage = "Refresh tokens expiretime has outdated" };


			var userRoles=await _userManager.GetRolesAsync(user);
			var tokenRequest = new TokenRequestDTO
			{
				UserName = user.UserName!,
				Email = user.Email!,
				Id = user.Id,
				Roles = userRoles,
			
			};
			var accessToken = _tokenService.GenerateAccessToken(tokenRequest);

			var refreshTokenObj = _tokenService.GenerateRefreshToken();
			_userManager.SetRefreshToken(user, refreshTokenObj, response);

			return new LoginResponse
			{
				AccessToken = accessToken,
				StatusCode = HttpStatusCode.OK
			};
		}

		public async Task<RegisterResponse> Register(RegisterRequest request)
		{
			string body = "Please confirm your account: <a href=\"http://localhost:5067/\">Click here to confirm</a>";
			
			

			return new RegisterResponse()
			{
				Message = "Registration is successful !"
			};
		}
	}
}
