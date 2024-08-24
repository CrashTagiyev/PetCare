using Application.ServiceAbstracts;
using Application.ServiceAbstracts.UserServices;
using Azure.Storage.Blobs;
using Infrastructure.ExternalServices;
using Infrastructure.InternalServices;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
			services.AddScoped<IBlobService, BlobService>();
			services.AddScoped<IVetService, VetService>();
			services.AddScoped<ICompanyService, CompanyService>();
			services.AddScoped<IShelterService, ShelterService>();

		}

		public static void AddPetCareImageBlobServiceClient(this IHostApplicationBuilder builder)
		{
			builder.Services.AddScoped(_ => {
				return new BlobServiceClient(builder.Configuration.GetConnectionString("AzurePetCareImageContainerConnectionString"));
			});
		}
	}


	
}
