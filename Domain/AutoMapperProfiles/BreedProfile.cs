using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class BreedProfile: Profile
{
    public BreedProfile()
    {
        // BreedReadDto ...
        CreateMap<Breed, BreedReadDto>();
        CreateMap<BreedReadDto, Breed>();
        
        // BreedWriteDto
        CreateMap<BreedWriteDto, Breed>();
        CreateMap<Breed, BreedWriteDto>();
    }
}