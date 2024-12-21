using AutoMapper;
using Domain.DTOs.AdminPanelDTOs.PetControlDTOs;
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
        CreateMap<PetWriteDto, Pet>()
            .ForMember(p=>p.ImageUrls,op=>op.Ignore());
        CreateMap<Pet, PetWriteDto>();

        //Admin read DTO
        CreateMap<Pet, PetReadAdminDTO>()
            .ForMember(p=>p.Shelter,op=>op.Ignore());
        CreateMap<PetReadAdminDTO, Pet>();

	}
}