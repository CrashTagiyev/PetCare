using Domain.Models.AuthModels.Request;
using Domain.Models.AuthModels.Response;
using Microsoft.AspNetCore.Http;

namespace Application.AbstractServices
{
	public interface IAuthService
	{
		Task<LoginResponse> Login(LoginRequest dto, HttpResponse response);
		Task<LoginResponse> RefreshToken(HttpRequest request, HttpResponse response);
	}
}
