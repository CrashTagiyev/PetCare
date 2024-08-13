using Domain.Models.AuthModels.Request;
using Domain.Models.AuthModels.Response;
using Microsoft.AspNetCore.Http;

namespace Application.ServiceAbstracts
{
	public interface IAuthService
	{
		Task<RegisterResponse> Register(RegisterRequest request);
		Task<ConfirmEmailResponse> ConfirmEmail(int userId, string token);
		Task<LoginResponse> Login(LoginRequest loginRequest);
		Task<LoginResponse> RefreshToken(string refreshToken);
		Task<ForgotPasswordResponse> ForgotPassword(ForgotPasswordRequest request);
		Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request);

	}
}
