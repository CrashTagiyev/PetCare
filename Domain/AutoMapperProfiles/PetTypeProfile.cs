using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class PetTypeProfile: Profile
{
    public PetTypeProfile()
    {
        // PetTypeReadDto ...
        CreateMap<PetType, PetTypeReadDto>();
        CreateMap<PetTypeReadDto, PetType>();
        
        // PetTypeWriteDto ...
        CreateMap<PetTypeWriteDto, PetType>();
        CreateMap<PetType, PetTypeWriteDto>();
    }
}