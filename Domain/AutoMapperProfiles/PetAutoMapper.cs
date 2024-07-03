using AutoMapper;
using Domain.DTOs.ReadDTO;
using Domain.Entities.Concretes;

namespace Domain.AutoMapperProfiles
{
	internal class PetAutoMapper : Profile
	{
		public PetAutoMapper()
		{
			CreateMap<PetReadDto, Pet>();
		}
	}
}
