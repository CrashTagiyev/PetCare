using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistance.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.BuilderRegisters
{
	public static class IdentityRegisters
	{

		public static void AddPetCareIdentity(this IServiceCollection services)
		{
			services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<PetCareDB>().AddDefaultTokenProviders();
		}
	}
}
