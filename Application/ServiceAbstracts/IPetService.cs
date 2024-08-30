using Domain.DTOs.ReadDTO;
using Domain.Models.EntityModels;

namespace Application.ServiceAbstracts
{
	public interface IPetService
	{
		Task<List<PetTypeReadDto>> GetPetTypesAsync();
		Task<List<BreedReadDto>> GetBreedTypesByPetTypeAsync(int PetTypeId);
		Task<List<PetReadDto>> GetFilteredPets(PetFilterModel filterModel);	
		Task<PetReadDto> GetPetByIdAsync(int PetId);
	}
}
