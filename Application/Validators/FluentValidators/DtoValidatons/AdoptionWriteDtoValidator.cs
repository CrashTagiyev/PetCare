using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class AdoptionWriteDtoValidator:AbstractValidator<AdoptionWriteDto>
	{
        public AdoptionWriteDtoValidator()
        {
            RuleFor(a=>a.PetId).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(a => a.UserId).NotNull().NotEmpty();
        }
    }
}
