using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repositories.EntityRepos.ReadRepos;
using Persistance.Repositories.EntityRepos.WriteRepos;
using Persistance.Repositories.IdentityRepos;

namespace Persistance.BuilderRegisters
{
	public static class RepositoryRegisters
	{
		public static void AddPetCareRepositories(this IServiceCollection services)
		{
			//Write repos

				//Entities
			services.AddScoped<IAcceptRequestWriteRepository, AcceptRequestWrieRepository>();
			services.AddScoped<IAdoptionWriteRepository, AdoptionWriteRepository>();
			services.AddScoped<IBreedWriteRepository, BreedWriteRepository>();
			services.AddScoped<IPetWriteRepository, PetWriteRepository>();
			services.AddScoped<IPetTypeWriteRepository, PetTypeWriteRepository>();
			services.AddScoped<IDonationWriteRepository, DonationWriteRepository>();
			//services.AddScoped<ILocationWriteRepository, LocationWriteRepository>();
			services.AddScoped<IShelterWriteRepository, ShelterWriteRepository>();
			services.AddScoped<IChatWriteRepository, ChatWriteRepository>();
			services.AddScoped<IMessageWriteRepository,MessageWriteRepository>();
			services.AddScoped<INotificationReadRepository,NotificationReadRepository>();
			services.AddScoped<INotificationWriteRepository,NotificationWriteRepository>();

			//App user
			services.AddScoped<IAppUserWriteRepository, AppUserWriteRepository>();
			
			//-----------------------------------------------------------------------------

			//Read repos

				//Entities
			services.AddScoped<IAcceptRequestReadRepository, AcceptRequestReadRepository>();
			services.AddScoped<IAdoptionReadRepository, AdoptionReadRepository>();
			services.AddScoped<IBreedReadRepository, BreedReadRepository>();
			services.AddScoped<IPetReadRepository, PetReadRepository>();
			services.AddScoped<IPetTypeReadRepository, PetTypeReadRepository>();
			services.AddScoped<IDonationReadRepository, DonationReadRepository>();
			//services.AddScoped<ILocationReadRepository, LocationReadRepository>();
			services.AddScoped<IShelterReadRepository, ShelterReadRepository>();
			services.AddScoped<IChatReadRepository, ChatReadRepository>();
			services.AddScoped<IMessageReadRepository, MessageReadRepository>();

				//App user
			services.AddScoped<IAppUserReadRepository, AppUserReadRepository>();


		}
	}
}
