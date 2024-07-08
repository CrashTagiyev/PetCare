using Application.AbstractServices;
using AutoMapper;
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
		private readonly IMapper _mapper;
		public AuthService(UserManager<AppUser> myUserManager, ITokenService tokenService, IEmailService emailService, IConfiguration configuration, IAppUserReadRepository appUserReadRepository, IMapper mapper)
		{
			_userManager = myUserManager;
			_tokenService = tokenService;
			_emailService = emailService;
			_configuration = configuration;
			_appUserReadRepository = appUserReadRepository;
			_mapper = mapper;
		}

		public async Task<RegisterResponse> Register(RegisterRequest request)
		{


			var userExist = await _userManager.FindByEmailAsync(request.Email);
			if (userExist != null)
			{
				var failedResponce = new RegisterResponse
				{
					StatusMessage = "User with this email is already exist",
					StatusCode = HttpStatusCode.BadRequest
				};
				return failedResponce;
			}

			userExist = await _userManager.FindByNameAsync(request.UserName);
			if (userExist != null)
			{
				var failedResponce = new RegisterResponse
				{
					StatusMessage = "User with this username is already exist",
					StatusCode = HttpStatusCode.BadRequest

				};
				return failedResponce;
			}

			var user = _mapper.Map<AppUser>(request);

			await _userManager.CreateAsync(user, request.Password!);
			await _userManager.AddToRoleAsync(user, "Admin");


			await _emailService.SendEmailConfirm(user);
			var responce = new RegisterResponse
			{
				StatusMessage = "Account created successfully.Please confirm registration from the email",
				StatusCode = HttpStatusCode.Created
			};
			return responce;

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
		public async Task<LoginResponse> Login(LoginRequest dto, HttpResponse response)
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

			var result = await _userManager.CheckPasswordAsync(user, dto.Password);
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
				RefreshToken = refreshToken.Token,
				StatusCode = HttpStatusCode.OK
			};
		}

		//Refresh tokeninde deyishiklikler edecem yoxlamamisham amma mence sehvdi
		public async Task<LoginResponse> RefreshToken(HttpRequest request, HttpResponse response)
		{
			var refreshToken = request.Cookies["refreshToken"];
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
			var accessToken = _tokenService.GenerateAccessToken(tokenRequest);

			var refreshTokenObj = _tokenService.GenerateRefreshToken();
			_userManager.SetRefreshToken(user, refreshTokenObj, response);

			return new LoginResponse
			{
				AccessToken = accessToken,
				StatusCode = HttpStatusCode.OK
			};
		}

		public async Task<ForgotPasswordResponse> ForgotPassword(ForgotPasswordRequest request)
		{
			var user = await _userManager.FindByEmailAsync(request.Email);
			if (user is not null)
			{
				var token = await _userManager.GeneratePasswordResetTokenAsync(user!);
				await _emailService.SendResetPassword(user, token);
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
				return new ResetPasswordResponse { StatusCode = HttpStatusCode.OK, StatusMessage = "Something is wrong" };

			}
			return new ResetPasswordResponse { StatusCode = HttpStatusCode.NotFound, StatusMessage = "User with this id did not found" };

		}
	}
}
