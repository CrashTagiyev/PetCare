using Application.ServiceAbstracts;
using Domain.DTOs.WriteDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SheltersController : ControllerBase
	{
		private readonly IShelterService _shelterService;

		public SheltersController(IShelterService shelterService)
		{
			_shelterService = shelterService;
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetShelters()
		{
			var shelterDTOs = await _shelterService.GetAllShelters();
			return Ok(shelterDTOs);
		}


		[HttpGet("[action]")]
		public async Task<IActionResult> GetShelterById(int id)
		{
			var shelterDTO = await _shelterService.GetShelterById();
			return Ok(shelterDTO);
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AddPetToShelter(int shelterId, PetWriteDto petWriteDto)
		{
			var result = await _shelterService.AddPetToShelter(shelterId, petWriteDto);
			return Ok(result);
		}
	}
}
