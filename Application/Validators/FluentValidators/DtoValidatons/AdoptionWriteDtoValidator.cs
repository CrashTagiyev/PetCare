using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class AdoptionWriteDtoValidator:AbstractValidator<AdoptionWriteDto>
	{
        public AdoptionWriteDtoValidator()
        {
            RuleFor(a => a.PetId)
                .NotNull().WithMessage("Pet Id can not be null")
                .NotEmpty().WithMessage("Pet Id can not be empty")
                .GreaterThan(0).WithMessage("Pet Id must be greater than 0");

            RuleFor(a => a.UserId)
                .NotNull().WithMessage("User Id can not be null")
                .NotEmpty().WithMessage("User Id can not be empty")
                .GreaterThan(0).WithMessage("User Id must be greater than 0");
        }
    }
}
