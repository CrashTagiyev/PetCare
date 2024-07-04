using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class PetProfile: Profile
{
    public PetProfile()
    {
        // PetReadDto ...
        CreateMap<Pet, PetReadDto>();
        CreateMap<PetReadDto, Pet>();
        
        // PetWriteDto ...
        CreateMap<PetWriteDto, Pet>();
        CreateMap<Pet, PetWriteDto>();

    }
}