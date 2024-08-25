using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using System.Net;

namespace Application.ServiceAbstracts
{
	public interface IShelterService
	{
		Task<List<ShelterReadDto>> GetAllShelters();
		Task<ShelterReadDto> GetShelterById();
		Task<HttpStatusCode> AddPetToShelter(PetWriteDto petWriteDto);
	}
}
