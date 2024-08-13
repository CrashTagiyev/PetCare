using Domain.DTOs.WriteDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class ShelterWriteDtoValidator : AbstractValidator<ShelterWriteDto>
	{
		public ShelterWriteDtoValidator()
		{
			RuleFor(s => s.CompanyId)
				.NotEmpty().WithMessage("Company Id can not be empty")
				.NotNull().WithMessage("Company Id can not be null")
				.GreaterThan(0).WithMessage("Company Id must be greater than 0");
		}
	}
}
