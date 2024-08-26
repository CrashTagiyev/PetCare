using Application.ServiceAbstracts;
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
		public async Task<IActionResult> GetPetsFiltered([FromBody]PetFilterModel filterModel)
		{
			var filteredPetDTOs = await _petService.GetFilteredPets(filterModel);
			return Ok(filteredPetDTOs);
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
