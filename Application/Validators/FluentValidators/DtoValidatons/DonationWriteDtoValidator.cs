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
            RuleFor(d => d.Amount)
                .GreaterThan(50).WithMessage("Donation amount must be greater than 50");

            RuleFor(d => d.CompanyId)
                .NotNull().WithMessage("Company Id can not be null")
                .NotEmpty().WithMessage("Company Id can not be empty")
                .GreaterThan(0).WithMessage("Company Id must be greater than 0");

            RuleFor(d => d.UserId)
                .NotNull().WithMessage("User Id can not be null")
                .NotEmpty().WithMessage("User Id can not be empty")
                .GreaterThan(0).WithMessage("User Id must be greater than 0");

        }
    }
}
