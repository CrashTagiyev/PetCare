using Application.ServiceAbstracts;
using Microsoft.AspNetCore.Http;
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


		[HttpGet("[action]")]
		public async Task<IActionResult> GetPetTypes()
		{
			var petTypesDTOs =await _petService.GetPetTypesAsync();
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
