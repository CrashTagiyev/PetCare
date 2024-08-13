using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class AdoptionProfile: Profile
{
    public AdoptionProfile()
    {
        // AdoptionReadDto ...
        CreateMap<Adoption, AdoptionReadDto>();
        CreateMap<AdoptionReadDto, Adoption>();
        
        // AdoptionWriteDto
        CreateMap<AdoptionWriteDto, Adoption>();
        CreateMap<Adoption, AdoptionWriteDto>();
    }
}