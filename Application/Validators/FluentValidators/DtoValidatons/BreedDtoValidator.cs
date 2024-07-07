using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class BreedDtoValidator : AbstractValidator<BreedWriteDto>
	{
		public BreedDtoValidator()
		{
			RuleFor(b => b.BreedName)
				.NotEmpty().WithMessage("Breed name can not be empty")
				.NotNull().WithMessage("Breed name can not be null")
				.Length(1, 25).WithMessage("Breed name must be between 1 and 25 characters");

			RuleFor(b => b.PetTypeId)
				.NotEmpty().WithMessage("PetType Id can not be empty")
				.NotNull().WithMessage("PetType Id can not be null")
				.GreaterThan(0).WithMessage("PetType Id must be greaater than 0");

		}
	}
}
