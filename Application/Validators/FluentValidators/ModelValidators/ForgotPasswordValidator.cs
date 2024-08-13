using Domain.AbstractRepositories.IdentityRepos;
using Domain.Models.AuthModels.Request;
using FluentValidation;

namespace Application.Validators.FluentValidators.ModelValidators;

public class ForgotPasswordValidator: AbstractValidator<ForgotPasswordRequest>
{
    public ForgotPasswordValidator(IAppUserReadRepository appUserReadRepository)
    {
        RuleFor(l => l.Email)
            .NotEmpty().WithMessage("Email address is required.")
            .EmailAddress().WithMessage("Invalid email address format.")
            .MaximumLength(255).WithMessage("Email address cannot exceed 255 characters.")
            .MustAsync(async (emailAddress, ct) => await appUserReadRepository.IsEmailExistAsync(emailAddress))
            .WithMessage("Email is not exist!");
    }
}