using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.WriteDTO;
using Domain.HelperMethods;
using Domain.Identity;
using FluentValidation;
using Microsoft.AspNetCore.Identity;


namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class ShelterWriteDtoValidator : AbstractValidator<ShelterWriteDto>
	{
		public ShelterWriteDtoValidator(UserManager<AppUser> userManager, IAppUserReadRepository appUserReadRepository, IShelterReadRepository shelterReadRepository)
		{
			RuleFor(s => s.CompanyId)
				.NotEmpty().WithMessage("Company Id can not be empty")
				.NotNull().WithMessage("Company Id can not be null")
				.GreaterThan(0).WithMessage("Company Id must be greater than 0")
				.MustAsync(async (companyId, ct) =>
				{
					var company = await appUserReadRepository.GetByIdAsync(companyId);
					if (company is null)
						return false;

					return true;
				}).WithMessage("Copany with this ID is not exist");

			RuleFor(s => s.ShelterName)
				.MustAsync(async (shelterName, ct) =>
				{
					var shelters = await shelterReadRepository.GetAllAsync();
					bool isShelterNameExist = shelters.Any(s => s.ShelterName.Contains(shelterName));
					
					if (isShelterNameExist)
						return false;

					return true;
				}).WithMessage("This shelter name is already exist");

			RuleFor(s => s.AdoptionPolicy)
				.NotEmpty().WithMessage("This place cannot be empty")
				.MinimumLength(30);

			RuleFor(s => s.AboutShelter)
				.NotEmpty().WithMessage("This place cannot be empty")
				.MinimumLength(30);

			RuleFor(s => s.ShelterImage)
				.NotNull().WithMessage("Please select the image of the shelter")
				.Must(HelperMethods.IsImageFile).WithMessage("Only image files are allowed.");

			RuleFor(s => s.City)
				.NotEmpty().WithMessage("Please select one of the cities");

			RuleFor(s => s.Address)
				.NotEmpty().WithMessage("Plesase write address of your shelter.");
		}
	}
}
