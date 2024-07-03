using Domain.Entities.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
