using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class PetWriteDtoValidator : AbstractValidator<PetWriteDto>
	{
		public PetWriteDtoValidator()
		{

			RuleFor(p => p.PetName)
				.NotEmpty().WithMessage("Pet name can not be empty")
				.NotNull().WithMessage("Pet name can not be null")
				.Length(3, 16).WithMessage("Pet name must be between 3 and 16 characters");

			RuleFor(p => p.Health)
				.NotEmpty().WithMessage("Health condition can not be empty")
				.NotNull().WithMessage("Health condition can not be null")
				.MaximumLength(120).WithMessage("Health condition must be max 120 characters");

			RuleFor(p => p.Size)
				.NotEmpty().WithMessage("Pet size can not be empty")
				.NotNull().WithMessage("Pet size can not be null");

			RuleFor(p => p.Weight)
				.NotEmpty().WithMessage("Pet weight can not be empty")
				.NotNull().WithMessage("Pet weight can not be null")
				.LessThan(120).WithMessage("Pet weight must be less than 120 kq");

			RuleFor(p => p.Description)
				.NotEmpty().WithMessage("Pet name can not be empty")
				.NotNull().WithMessage("Pet name can not be null");

			RuleFor(p => p.Gender)
				.NotEmpty().WithMessage("Pet gender can not be empty")
				.NotNull().WithMessage("Pet gender can not be null");

			RuleFor(p => p.Age)
				.NotEmpty().WithMessage("Pet age can not be empty")
				.NotNull().WithMessage("Pet age can not be null")
				.LessThan((short)21).WithMessage("Pet age must be less than 21");

			RuleFor(p => p.PetTypeId)
				.NotEmpty().WithMessage("PetType Id can not be empty")
				.NotNull().WithMessage("PetType Id can not be null")
				.GreaterThan(0).WithMessage("PetType Id must be greater than 0");

			RuleFor(p => p.ShelterId)
				.NotEmpty().WithMessage("Shelter Id can not be empty")
				.NotNull().WithMessage("Shelter Id can not be null")
				.GreaterThan(0).WithMessage("Shelter Id must be greater than 0");
			
			RuleFor(p => p.BreedId)
				.NotEmpty().WithMessage("Breed Id can not be empty")
				.NotNull().WithMessage("Breed Id can not be null")
				.GreaterThan(0).WithMessage("Breed Id must be greater than 0");

		}
	}
}
