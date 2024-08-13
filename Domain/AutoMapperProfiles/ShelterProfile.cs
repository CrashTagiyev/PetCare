using AutoMapper;
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
	}
}