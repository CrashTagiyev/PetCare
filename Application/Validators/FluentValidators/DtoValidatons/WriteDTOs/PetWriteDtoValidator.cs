using Domain.DTOs.WriteDTO;
using FluentValidation;

namespace Application.Validators.FluentValidators.DtoValidatons.WriteDTOs
{
	public class PetWriteDtoValidator : AbstractValidator<PetWriteDto>
	{
        public PetWriteDtoValidator()
        {
            RuleFor(p=>p.PetName).NotEmpty().NotNull();   
            RuleFor(p=>p.Health).NotEmpty().NotNull();   
            RuleFor(p=>p.Size).NotEmpty().NotNull();   
            RuleFor(p=>p.Weight).NotEmpty().NotNull();   
            RuleFor(p=>p.Description).NotEmpty().NotNull();   
            RuleFor(p=>p.Gender).NotEmpty().NotNull();   
            RuleFor(p=>p.PetTypeId).NotEmpty().NotNull();   
            RuleFor(p=>p.Age).NotEmpty().NotNull();   
        }
    }
}
