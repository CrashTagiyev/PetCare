using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistance.Database;

namespace Persistance.BuilderRegisters
{
	public static class PetCareDbContextRegisters
	{
		public static void AddPetCareDbContext(this IHostApplicationBuilder builder)
		{

			builder.Services.AddDbContext<PetCareDB>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
			});
		}
	}
}
