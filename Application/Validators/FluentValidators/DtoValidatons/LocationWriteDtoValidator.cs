using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class LocationWriteDtoValidator : AbstractValidator<LocationWriteDto>
	{
		public LocationWriteDtoValidator()
		{
			RuleFor(l => l.City)
				.NotNull().WithMessage("City name can not be null")
				.NotEmpty().WithMessage("City name can not be empty");
			
			RuleFor(l=>l.Region)
				.NotNull().WithMessage("Region name can not be null")
				.NotEmpty().WithMessage("Region name can not be empty");
			
			RuleFor(l=>l.Street)
				.NotNull().WithMessage("Street name can not be null")
				.NotEmpty().WithMessage("Street name can not be empty");
			
		}
	}
}
