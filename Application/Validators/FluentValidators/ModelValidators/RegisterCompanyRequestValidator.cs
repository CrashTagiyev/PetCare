using Domain.AbstractRepositories.IdentityRepos;
using Domain.HelperMethods;
using Domain.Identity;
using Domain.Models.AuthModels.Request;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Application.Validators.FluentValidators.ModelValidators
{
	public class RegisterCompanyRequestValidator : AbstractValidator<RegisterCompanyRequest>
	{
		private readonly IAppUserReadRepository _appUserReadRepository;
		private readonly UserManager<AppUser> _userManager;
		public RegisterCompanyRequestValidator(IAppUserReadRepository appUserReadRepository, UserManager<AppUser> userManager)
		{
			_userManager = userManager;
			_appUserReadRepository = appUserReadRepository;

			RuleFor(rc => rc.UserName)
				.NotEmpty().WithMessage("User name is required.")
				.MaximumLength(50).WithMessage("User name cannot exceed 50 characters.")
				.MustAsync(async (companyName, ct) => !await appUserReadRepository.IsUserNameExistAsync(companyName))
				.WithMessage("This Company name is already exists.");

			RuleFor(rc => rc.Email)
				.NotEmpty().WithMessage("Email address is required.")
				.EmailAddress().WithMessage("Invalid email address format.")
				.MaximumLength(255).WithMessage("Email address cannot exceed 255 characters.")
				.MustAsync(async (email, ct) => !await appUserReadRepository.IsEmailExistAsync(email))
				.WithMessage("This email address is already exists.");

			RuleFor(rc => rc.Password)
				.NotEmpty().WithMessage("Password is required.")
				.MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
				.MaximumLength(100).WithMessage("Password cannot exceed 100 characters.")
				.Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
				.Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
				.Matches("[0-9]").WithMessage("Password must contain at least one number.")
				.Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");

			RuleFor(rc => rc.About)
				.NotEmpty();

			RuleFor(rc => rc.ProfileImage)
				.NotNull().WithMessage("Company image is required")
				.Must(HelperMethods.IsImageFile).WithMessage("Invalid image file. Only image files are allowed.");
		}
	}
}
