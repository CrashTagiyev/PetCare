using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class PetWriteDtoValidator : AbstractValidator<PetWriteDto>
	{
		public PetWriteDtoValidator()
		{

			RuleFor(p => p.PetName).NotEmpty().NotNull().MaximumLength(16).MinimumLength(3);

			RuleFor(p => p.Health).NotEmpty().NotNull().MaximumLength(120);

			RuleFor(p => p.Size).NotEmpty().NotNull();

			RuleFor(p => p.Weight).NotEmpty().NotNull();

			RuleFor(p => p.Description).NotEmpty().NotNull();

			RuleFor(p => p.Gender).NotEmpty().NotNull();

			RuleFor(p => p.Age).NotEmpty().NotNull();

			RuleFor(p => p.PetTypeId).NotEmpty().NotNull().GreaterThan(0);

			RuleFor(p => p.ShelterId);
			
			RuleFor(p => p.BreedId).NotEmpty().NotNull().GreaterThan(0);

		}
	}
}
