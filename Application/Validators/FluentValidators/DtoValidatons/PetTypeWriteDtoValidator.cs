using Domain.DTOs.WriteDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.FluentValidators.DtoValidatons
{
	public class PetTypeWriteDtoValidator:AbstractValidator<PetTypeWriteDto>
	{
        public PetTypeWriteDtoValidator()
        {
            RuleFor(pt => pt.TypeName)
                .NotEmpty().WithMessage("Type name can not be empty")
                .NotNull().WithMessage("Type name can not be null")
                .Length(1, 20).WithMessage("Type name must be between 1 and 20 characters");
        }
    }
}
