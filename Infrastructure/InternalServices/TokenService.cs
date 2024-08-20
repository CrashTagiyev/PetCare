using Application.ServiceAbstracts;
using Domain.DTOs.TokenDTOs;
using Domain.Models.AuthModels.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.ExternalServices
{
	public class TokenService : ITokenService
	{
		private readonly IConfiguration _configuration;


		public TokenService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public async Task<string> GenerateAccessToken(TokenRequestDTO dto)
		{
			var secredKey = _configuration["Jwt:Key"]!;
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secredKey));
			var roles = string.Join(",", dto.Roles!);
				var tokenDescription = new SecurityTokenDescriptor()
				{
					//Expires = DateTime.UtcNow.add(_configuration.GetValue<int>("JWT:AccessTokenExpireHours")),
					Expires = DateTime.UtcNow.AddMinutes(5),
					Issuer = _configuration["Jwt:Issuer"],
					Audience = _configuration["Jwt:Audience"],
					SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256),
					Subject = new ClaimsIdentity(new Claim[] {
					new Claim(ClaimTypes.Role,roles),
					new Claim(ClaimTypes.Email, dto.Email!),
					new Claim("id",dto.Id.ToString() ?? string.Empty),
					new Claim("username",dto.UserName ?? string.Empty),
					new Claim("firstname",dto.FirstName?? string.Empty),
					new Claim("lastname",dto.LastName?? string.Empty),
					new Claim("lastname",dto.LastName?? string.Empty),
					new Claim("profileimageurl",dto.ProfileImageUrl?? string.Empty),
					new Claim("expireAt",DateTime.Now.AddHours(_configuration.GetValue<int>("JWT:AccessTokenExpireHours")).ToString())
					})
				};
				var tokenHandler = new JwtSecurityTokenHandler();
				SecurityToken? token = tokenHandler.CreateToken(tokenDescription);

				return tokenHandler.WriteToken(token);



		}


		public async Task<RefreshToken> GenerateRefreshToken()
		{
			var refreshToken = new RefreshToken()
			{
				Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
				ExpireTime = DateTime.Now.AddHours(_configuration.GetValue<int>("JWT:RefreshTokenExpireHours")),
				CreateTime = DateTime.Now
			};
			return refreshToken;
		}




	}
}
