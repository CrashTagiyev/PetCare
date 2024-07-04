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
			RuleFor(s => s.CompanyId).NotEmpty().NotNull();
			RuleFor(s => s.LocationId).NotEmpty().NotNull();
		}
	}
}
