using Domain.DTOs.WriteDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class PetTypeDtoValidator:AbstractValidator<PetTypeWriteDto>
	{
        public PetTypeDtoValidator()
        {
            RuleFor(pt=>pt.TypeName).NotEmpty().NotNull().MinimumLength(1).MaximumLength(20);
        }
    }
}
