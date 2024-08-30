using Application.ServiceAbstracts;
using Domain.DTOs.ReadDTO;
using Domain.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PetController : ControllerBase
	{
		private readonly IPetService _petService;

		public PetController(IPetService petService)
		{
			_petService = petService;
		}


		[HttpPost("[action]")]
		public async Task<IActionResult> GetPetsFiltered([FromBody] PetFilterModel filterModel)
		{
			List<PetReadDto> filteredPetDTOs = await _petService.GetFilteredPets(filterModel);
			int totalPets = filteredPetDTOs.Count();
			int skip = (filterModel!.PageNumber - 1) * filterModel.PageSize;
			filteredPetDTOs = filteredPetDTOs.Skip(skip).Take(filterModel.PageSize).ToList();
			return Ok(new { petsArray = filteredPetDTOs, totalPets = totalPets });
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetPetById(int id)
		{
			var petDTO = await _petService.GetPetByIdAsync(id);
			return Ok(petDTO);	
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetPetTypes()
		{
			var petTypesDTOs = await _petService.GetPetTypesAsync();
			return Ok(petTypesDTOs);
		}


		[HttpGet("[action]")]
		public async Task<IActionResult> GetPetTypeBreeds(int petTypeId)
		{
			var breedsDTOs = await _petService.GetBreedTypesByPetTypeAsync(petTypeId);
			return Ok(breedsDTOs);
		}
	}
}
