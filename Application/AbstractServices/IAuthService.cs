using Domain.Models.AuthModels.Request;
using Domain.Models.AuthModels.Response;
using Microsoft.AspNetCore.Http;

namespace Application.AbstractServices
{
	public interface IAuthService
	{
		Task<RegisterResponse> Register(RegisterRequest request);
		Task<ConfirmEmailResponse> ConfirmEmail(int userId, string token);
		Task<LoginResponse> Login(LoginRequest dto, HttpResponse response);
		Task<LoginResponse> RefreshToken(HttpRequest request, HttpResponse response);
		Task<ForgotPasswordResponse> ForgotPassword(ForgotPasswordRequest request);
		Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request);

	}
}
