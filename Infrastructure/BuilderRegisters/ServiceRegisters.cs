using Application.AbstractServices;
using Infrastructure.ExternalServices;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.BuilderRegisters
{
	public static class ServiceRegisters
	{
		public static void AddPetCareServices(this IServiceCollection services)
		{
			services.AddScoped<IEmailService, EmailService>();
			services.AddScoped<IAuthService, AuthService>();
			services.AddScoped<ITokenService, TokenService>();
		}
	}
}
