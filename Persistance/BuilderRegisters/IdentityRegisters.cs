using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Database;


namespace Persistance.BuilderRegisters
{
	public static class IdentityRegisters
	{

		public static void AddPetCareIdentity(this IServiceCollection services)
		{
			services.AddIdentity<AppUser, IdentityRole<int>>().AddEntityFrameworkStores<PetCareDB>().AddDefaultTokenProviders();
		}
	}
}
