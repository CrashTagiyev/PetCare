using Application.AbstractServices;
using Domain.DTOs.TokenDTOs;
using Domain.Models.AuthModels.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.WebSockets;
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
				Expires = DateTime.Now.AddHours(_configuration.GetValue<int>("JWT:AccessTokenExpireHours")),
				Issuer = _configuration["Jwt:Issuer"],
				Audience = _configuration["Jwt:Audience"],
				SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256),
				
				Subject = new ClaimsIdentity(new Claim[] {
				new Claim(ClaimTypes.Role,roles),
				new Claim(ClaimTypes.Email, dto.Email!),
				new Claim("username",dto.UserName)
				})
			};

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(tokenDescription.Expires);
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
