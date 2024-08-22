using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class LocationProfile: Profile
{
    public LocationProfile()
    {
        // LocationReadDto ...
        //CreateMap<Location, LocationReadDto>();
        //CreateMap<LocationReadDto, Location>();
        
        //// LocationWriteDto ...
        //CreateMap<LocationWriteDto, Location>();
        //CreateMap<Location, LocationWriteDto>();
    }
}