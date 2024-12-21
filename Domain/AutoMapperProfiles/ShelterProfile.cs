using AutoMapper;
using Domain.DTOs.AdminPanelDTOs;
using Domain.DTOs.AdminPanelDTOs.ShelterControlDTOs;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles;

public class ShelterProfile : Profile
{
	public ShelterProfile()
	{
		// ShelterReadDto ...
		CreateMap<Shelter, ShelterReadDto>();
		CreateMap<ShelterReadDto, Shelter>();

		// ShelterWriteDto ...
		CreateMap<ShelterWriteDto, Shelter>();
		CreateMap<Shelter, ShelterWriteDto>();

		//Admin read DTO
		CreateMap<Shelter, ShelterReadAdminDTO>()
		.ForMember(dest => dest.Company, opt => opt.MapFrom(src => new CompanyReadAdminDTO
		{
			Id = src.Company.Id,
			CompanyName = src.Company.CompanyName,
			ProfileImageUrl = src.Company.ProfileImageUrl,
			CreatedTime = src.Company.CreatedTime,
			UserName = src.Company.UserName,
			PhoneNumber = src.Company.PhoneNumber,
			About = src.Company.About,
			Email = src.Company.Email,
			LastUpdatedTime = src.Company.LastUpdatedTime,
		}));
		CreateMap<ShelterReadAdminDTO, Shelter>();

	}
}