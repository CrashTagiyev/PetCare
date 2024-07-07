using Azure;
using Domain.Identity;
using Domain.Models.AuthModels.Tokens;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.HelperMethods.Extenstions
{
	public static class UserManagerExtensions
	{
		public static void SetRefreshToken(this UserManager<AppUser> userManager, AppUser user, RefreshToken refreshToken,HttpResponse response)
		{
			var cookieOptions = new CookieOptions()
			{
				HttpOnly = true,
				Expires = refreshToken.ExpireTime
			};

			response.Cookies.Append("refreshToken", refreshToken.Token, cookieOptions);

			user.RefreshToken = refreshToken.Token;
			user.RefreshTokenCreateTime = refreshToken.CreateTime;
			user.RefreshTokenExpireTime = refreshToken.ExpireTime;

			userManager.UpdateAsync(user);
		}
	}
}
