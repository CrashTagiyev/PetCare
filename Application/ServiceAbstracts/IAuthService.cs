using Domain.Models.AuthModels.Request;
using Domain.Models.AuthModels.Response;
using Microsoft.AspNetCore.Http;

namespace Application.ServiceAbstracts
{
	public interface IAuthService
	{
		Task<RegisterResponse> Register(RegisterRequest registerRequest);
		Task<RegisterResponse> RegisterCompany(RegisterCompanyRequest registerCompanyRequest);
		Task<RegisterResponse> RegisterVet(RegisterVetRequest registerVetRequest);
		Task<ConfirmEmailResponse> ConfirmEmail(int userId, string token);
		Task<LoginResponse> Login(LoginRequest loginRequest,HttpContext context);
		Task<LoginResponse> RefreshToken(HttpContext context);
		Task SetRefreshTokenInsideHttpOnlyCookie(string refreshToken, HttpContext context);
		Task<ForgotPasswordResponse> ForgotPassword(ForgotPasswordRequest request);
		Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request);

	}
}
