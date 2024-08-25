using Domain.DTOs.ReadDTO;

namespace Application.ServiceAbstracts
{
	public interface IPetService
	{
		Task<List<PetTypeReadDto>> GetPetTypesAsync();
		Task<List<BreedReadDto>> GetBreedTypesByPetTypeAsync(int PetTypeId);
	}
}
