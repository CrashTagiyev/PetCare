using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;

namespace Application.ServiceAbstracts
{
	public interface IShelterService
	{
		Task<List<ShelterReadDto>> GetAllShelters();
		Task<ShelterReadDto> GetShelterById();

		Task<string> AddPetToShelter(int shelterId,PetWriteDto petWriteDto);
	}
}
