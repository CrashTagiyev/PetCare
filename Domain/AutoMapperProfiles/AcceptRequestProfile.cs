using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class AcceptRequestProfile: Profile
{
    public AcceptRequestProfile()
    {
        // AcceptRequestReadDto ...
        CreateMap<AcceptRequest,AcceptRequestReadDto>();
        CreateMap<AcceptRequestReadDto,AcceptRequest>();
        
        // AcceptRequestWriteDto ...
        CreateMap<AcceptRequestWriteDto, AcceptRequest>();
        CreateMap<AcceptRequest,AcceptRequestWriteDto>();
        
    }
}