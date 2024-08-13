﻿using Application.Validators.FluentValidators.ModelValidators;
using Domain.Models.AuthModels.Request;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
namespace Application.BuilderRegisters
{
	public static class ValidatorRegisters
	{
		public static void AddPetCareFluentValidators(this IServiceCollection services)
		{
			services.AddFluentValidationAutoValidation(configuration =>
			{

				configuration.DisableBuiltInModelValidation = true;

				configuration.EnableBodyBindingSourceAutomaticValidation = true;

				configuration.EnableFormBindingSourceAutomaticValidation = true;

				configuration.EnableQueryBindingSourceAutomaticValidation = true;

				configuration.EnablePathBindingSourceAutomaticValidation = true;

				configuration.EnableCustomBindingSourceAutomaticValidation = true;

			});
			services.AddScoped<IValidator<LoginRequest>,LoginRequestValidator>();
			services.AddScoped<IValidator<RegisterRequest>,RegisterRequestValidator>();
			services.AddScoped<IValidator<ForgotPasswordRequest>,ForgotPasswordValidator>();
			services.AddScoped<IValidator<ResetPasswordRequest>,ResetPasswordValidator>();
		}
	}
}
