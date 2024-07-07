using Domain.DTOs.WriteDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators.FluentValidators.DtoValidatons
{
    public class AccepRequestDTOValidator : AbstractValidator<AcceptRequestWriteDto>
    {
        public AccepRequestDTOValidator()
        {
            RuleFor(ar => ar.UserId)
                .NotEmpty().WithMessage("User Id can not be empty")
                .NotNull().WithMessage("User Id can not be null");
            
            RuleFor(ar => ar.Pet)
                .NotEmpty().WithMessage("Pet can not be empty")
                .NotNull().WithMessage("Pet can not be null");
            
            RuleFor(ar => ar.Description)
                .NotEmpty().WithMessage("Description can not be empty")
                .NotNull().WithMessage("Description can not be null");
        }
    }
}
