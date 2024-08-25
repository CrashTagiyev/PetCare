using Application.ServiceAbstracts;
using Domain.DTOs.WriteDTO;
using Microsoft.AspNetCore.Authorization;
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
		//[Authorize(Roles ="Company")]
		public async Task<IActionResult> AddPetToShelter([FromForm]PetWriteDto petWriteDto)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await _shelterService.AddPetToShelter(petWriteDto);
			return Ok(result);
		}
	}
}
