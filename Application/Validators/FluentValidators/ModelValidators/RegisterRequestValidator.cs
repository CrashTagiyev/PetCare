using Domain.Models.AuthModels.Request;
using FluentValidation;

namespace Application.Validators.FluentValidators.ModelValidators;

public class RegisterRequestValidator: AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(x => x.Firstname)
            .NotEmpty().WithMessage("First name is required.")
            .MaximumLength(50).WithMessage("First name cannot exceed 50 characters.")
            .Matches("^[a-zA-Z]+$").WithMessage("First name must contain only letters.");
        
        RuleFor(x => x.Lastname)
            .NotEmpty().WithMessage("Last name is required.")
            .MaximumLength(50).WithMessage("Last name cannot exceed 50 characters.")
            .Matches("^[a-zA-Z]+$").WithMessage("Last name must contain only letters.");

        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("User name is required.")
            .MaximumLength(50).WithMessage("User name cannot exceed 50 characters.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email address is required.")
            .EmailAddress().WithMessage("Invalid email address format.")
            .MaximumLength(255).WithMessage("Email address cannot exceed 255 characters.");

        RuleFor(x => x.DateOfBirth)
            .NotEmpty().WithMessage("Date of birth is required.")
            .Must(BeAValidAge).WithMessage("Invalid date of birth.");

        RuleFor(x => x.City)
            .MaximumLength(100).WithMessage("City name cannot exceed 100 characters.");

        RuleFor(x => x.Address)
            .MaximumLength(255).WithMessage("Address cannot exceed 255 characters.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
            .MaximumLength(100).WithMessage("Password cannot exceed 100 characters.")
            .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
            .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
            .Matches("[0-9]").WithMessage("Password must contain at least one number.")
            .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");
    }
    
    private bool BeAValidAge(DateTime? date)
    {
        if (!date.HasValue)
            return false;
        
        int age = DateTime.Today.Year - date.Value.Year;
        if (date.Value.Date > DateTime.Today.AddYears(-age)) age--;
        return age >= 18;
    }
}