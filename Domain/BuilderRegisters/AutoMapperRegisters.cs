using Domain.Entities.Abstracts;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.BuilderRegisters
{
	public static class AutoMapperRegisters
	{
		public static void AddPetCareAutoMapper(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(Entity));
		}
	}
}
