using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class BreedDtoValidator : AbstractValidator<BreedWriteDto>
	{
		public BreedDtoValidator()
		{
			RuleFor(b=>b.BreedName).NotEmpty().NotNull().MinimumLength(1).MaximumLength(25);
			RuleFor(b => b.PetTypeId).GreaterThan(0).NotEmpty();

		}
	}
}
