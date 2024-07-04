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
            RuleFor(ar => ar.UserId).NotEmpty().NotNull();
            RuleFor(ar => ar.Pet).NotEmpty().NotNull();
            RuleFor(ar => ar.Description).NotEmpty().NotNull();
        }
    }
}
