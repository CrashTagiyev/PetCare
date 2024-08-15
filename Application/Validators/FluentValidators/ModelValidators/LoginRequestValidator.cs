using Domain.AbstractRepositories.IdentityRepos;
using Domain.Models.AuthModels.Request;
using FluentValidation;

namespace Application.Validators.FluentValidators.ModelValidators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{

	public LoginRequestValidator(IAppUserReadRepository appUserReadRepository)
	{

		RuleFor(l => l.EmailAddress)
			.NotEmpty().WithMessage("Email address is required.")
			.EmailAddress().WithMessage("Invalid email address format.")
			.MaximumLength(255).WithMessage("Email address cannot exceed 255 characters.")
			.MustAsync(async (emailAddress, ct) =>
			{
				return await appUserReadRepository.IsEmailConfirmedAsync(emailAddress);
			})
			.WhenAsync(async (lr, ct) => await appUserReadRepository.IsEmailExistAsync(lr.EmailAddress))
			.WithMessage("Email is not confirmed.")
			.MustAsync(async (emailAddress, ct) =>
			{
				return await appUserReadRepository.IsEmailExistAsync(emailAddress);
			})
			.WithMessage("Email does not exist.")
			.EmailAddress().WithMessage("Email addres is not valid");

	

		RuleFor(l => l.Password)
			.NotEmpty().WithMessage("Password is required.")
			.MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
			.MaximumLength(100).WithMessage("Password cannot exceed 100 characters.")
			.Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
			.Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
			.Matches("[0-9]").WithMessage("Password must contain at least one number.")
			.Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");

	}


}