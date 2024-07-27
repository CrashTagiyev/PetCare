using Application.ServiceAbstracts;
using Infrastructure.ExternalServices;
using Infrastructure.InternalServices;
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
			services.AddScoped<IHubService, HubService>();
		}

		
	}


	
}
