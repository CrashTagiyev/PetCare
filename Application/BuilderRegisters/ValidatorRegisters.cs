using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

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
