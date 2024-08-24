using Domain.DTOs.ReadDTO;

namespace Application.ServiceAbstracts
{
	public interface IShelterService
	{
		Task<List<ShelterReadDto>> GetAllShelters();
		Task<ShelterReadDto> GetShelterById();
	}
}
