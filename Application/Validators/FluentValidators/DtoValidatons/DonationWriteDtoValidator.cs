using Domain.DTOs.WriteDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class DonationWriteDtoValidator:AbstractValidator<DonationWriteDto>
	{
        public DonationWriteDtoValidator()
        {
            RuleFor(d=>d.Amount).GreaterThan(50);
            RuleFor(d => d.CompanyId).NotNull().NotEmpty();
            RuleFor(d => d.UserId).NotNull().NotEmpty();

        }
    }
}
