using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuilderRegisters
{
	public static class ValidatorRegisters
	{
		public static void AddPetCareFluentValidators(this IServiceCollection services)
		{
			services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters().AddValidatorsFromAssemblyContaining<ApplicationAssemblyMarker>();
		}
	}
}
