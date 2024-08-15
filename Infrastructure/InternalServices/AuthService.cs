using Application.ServiceAbstracts;
using AutoMapper;
using Azure.Core;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.TokenDTOs;
using Domain.Identity;
using Domain.Models.AuthModels.Request;
using Domain.Models.AuthModels.Response;
using Domain.Models.AuthModels.Tokens;
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
		private readonly IMapper _mapper;
		private readonly IBlobService _blobService;

		public AuthService(UserManager<AppUser> myUserManager, ITokenService tokenService, IEmailService emailService, IConfiguration configuration, IAppUserReadRepository appUserReadRepository, IMapper mapper, IBlobService blobService)
		{
			_userManager = myUserManager;
			_tokenService = tokenService;
			_emailService = emailService;
			_configuration = configuration;
			_appUserReadRepository = appUserReadRepository;
			_mapper = mapper;
			_blobService = blobService;
		}

		public async Task<RegisterResponse> Register(RegisterRequest request)
		{

			var user = _mapper.Map<AppUser>(request);

			if (request.ProfileImage is not null)
				user.ProfileImageUrl = await _blobService.UploadImageFileAsync(request.ProfileImage);

			var result = await _userManager.CreateAsync(user, request.Password!);

			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, "User");
				//await _emailService.SendEmailConfirm(user);
				var successRespose = new RegisterResponse
				{
					StatusMessage = "Account created successfully.Please confirm registration from the email",
					StatusCode = HttpStatusCode.Created
				};
				return successRespose;
			}
			var badResponse = new RegisterResponse
			{
				StatusMessage = "Registration failed.something vent wrong",
				StatusCode = HttpStatusCode.Created
			};
			return badResponse;
		}

		public async Task<ConfirmEmailResponse> ConfirmEmail(int userId, string token)
		{
			var user = await _appUserReadRepository.GetByIdAsync(userId);
			if (user is null)
				return new ConfirmEmailResponse
				{
					StatusMessage = "User with this id was not found",
					StatusCode = HttpStatusCode.BadRequest
				};

			if (user.EmailConfirmed)
				return new ConfirmEmailResponse
				{
					StatusMessage = "You already confirmed your email",
					StatusCode = HttpStatusCode.BadRequest
				};


			token = token.Replace(" ", "+");
			var result = await _userManager.ConfirmEmailAsync(user, token);
			if (!result.Succeeded)
				return new ConfirmEmailResponse
				{
					StatusCode = HttpStatusCode.BadRequest,
					StatusMessage = "Something is wrong or maybe token is expired"
				};

			return new ConfirmEmailResponse
			{
				StatusCode = HttpStatusCode.OK,
				StatusMessage = "Email successfully confirmed"
			};


		}
		public async Task<LoginResponse> Login(LoginRequest loginRequest)
		{

			var user = await _userManager.FindByEmailAsync(loginRequest.EmailAddress);
			if (user is not null)
			{

				var roles = await _userManager.GetRolesAsync(user);
				var tokenRequestDto = new TokenRequestDTO
				{
					Email = loginRequest.EmailAddress,
					Id = user.Id,
					UserName = user.UserName!,
					Roles = roles.ToList(),
					FirstName=user.Firstname,
					LastName=user.Lastname,
					ProfileImageUrl = user.ProfileImageUrl??string.Empty,
					Claims = new List<Claim>
				{
					new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
					new Claim(ClaimTypes.Email, loginRequest.EmailAddress),
					new Claim(ClaimTypes.Name, user.UserName!),
					new Claim(ClaimTypes.Role, string.Join(",", roles.ToList()))
				}

				};
				var accessToken = await _tokenService.GenerateAccessToken(tokenRequestDto);
				var refreshToken = await _tokenService.GenerateRefreshToken();

				user.RefreshToken = refreshToken.Token;
				user.RefreshTokenExpireTime = refreshToken.ExpireTime;
				await _userManager.UpdateAsync(user);
				return new LoginResponse
				{
					AccessToken = accessToken,
					RefreshToken = refreshToken.Token,
					StatusCode = HttpStatusCode.OK
				};
			}
			return new LoginResponse
			{
				StatusCode = HttpStatusCode.BadRequest
			};
		}
		public async Task<LoginResponse> RefreshToken(string refreshToken)
		{
			if (string.IsNullOrEmpty(refreshToken))
				return new LoginResponse { StatusCode = HttpStatusCode.Forbidden, StatusMessage = "Invalid refresh token" };

			var user = await _appUserReadRepository.FinByRefreshToken(refreshToken);
			if (user is null)
				return new LoginResponse { StatusCode = HttpStatusCode.Forbidden, StatusMessage = "Invalid refresh token,User did with this refresh token did not found" };


			if (user.RefreshTokenExpireTime < DateTime.Now)
				return new LoginResponse { StatusCode = HttpStatusCode.Forbidden, StatusMessage = "Refresh tokens expiretime has outdated" };


			var userRoles = await _userManager.GetRolesAsync(user);
			var tokenRequest = new TokenRequestDTO
			{
				UserName = user.UserName!,
				Email = user.Email!,
				Id = user.Id,
				Roles = userRoles,

			};
			var accessToken = await _tokenService.GenerateAccessToken(tokenRequest);

			var refreshTokenObj = await _tokenService.GenerateRefreshToken();

			return new LoginResponse
			{
				AccessToken = accessToken,
				RefreshToken = refreshTokenObj.Token,
				StatusCode = HttpStatusCode.OK,
				StatusMessage = "Refresh token successfully refreshed"
			};
		}
		public async Task<ForgotPasswordResponse> ForgotPassword(ForgotPasswordRequest request)
		{
			var user = await _userManager.FindByEmailAsync(request.Email);
			if (user is not null)
			{
				var token = await _userManager.GeneratePasswordResetTokenAsync(user!);
				//await _emailService.SendResetPassword(user, token);
				return new ForgotPasswordResponse { StatusCode = HttpStatusCode.OK, StatusMessage = "Reset password link send to your email", Token = token, UserId = user.Id };
			}
			return new ForgotPasswordResponse { StatusCode = HttpStatusCode.NotFound, StatusMessage = "Incorrect email.Email was not found" };
		}
		public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request)
		{
			var user = await _appUserReadRepository.GetByIdAsync(request.UserId);
			if (user is not null)
			{
				var result = await _userManager.ResetPasswordAsync(user, request.Token, request.NewPassword);
				if (result.Succeeded)
				{
					return new ResetPasswordResponse { StatusCode = HttpStatusCode.OK, StatusMessage = "Password has successfully changed" };
				}
				var errors = string.Join(", ", result.Errors.Select(e => e.Description));
				return new ResetPasswordResponse
				{
					StatusCode = HttpStatusCode.BadRequest,
					StatusMessage = $"Password reset failed: {errors}"
				};

			}
			return new ResetPasswordResponse { StatusCode = HttpStatusCode.NotFound, StatusMessage = "User with this id did not found" };

		}
	}
}
