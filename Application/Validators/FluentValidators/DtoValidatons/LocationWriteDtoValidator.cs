using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class LocationWriteDtoValidator : AbstractValidator<LocationWriteDto>
	{
		public LocationWriteDtoValidator()
		{
			RuleFor(l=>l.City).NotNull().NotEmpty();
			RuleFor(l=>l.Region).NotNull().NotEmpty();
			RuleFor(l=>l.Street).NotNull().NotEmpty();
			
		}
	}
}
