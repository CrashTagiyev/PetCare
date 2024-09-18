using Application.ServiceAbstracts;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Models.EntityModels;
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

		[HttpPost("[action]")]
		public async Task<IActionResult> GetShelters([FromBody]ShelterFilterModel shelterFilterModel)
		{
			var shelterDTOs = await _shelterService.GetAllShelters();
			int totalShelters = shelterDTOs.Count();
			int skip = (shelterFilterModel!.PageNumber - 1) * shelterFilterModel.PageSize;
			shelterDTOs = shelterDTOs.Skip(skip).Take(shelterFilterModel.PageSize).ToList();	
			return Ok(new { sheltersArray = shelterDTOs, totalShelters = totalShelters });
		}



		[HttpGet("[action]")]
		public async Task<IActionResult> GetShelterById(int id)
		{
			var shelterDTO = await _shelterService.GetShelterById();
			return Ok(shelterDTO);
		}

		[HttpPost("[action]")]
		[Authorize(Roles = "Company")]
		public async Task<IActionResult> AddPetToShelter([FromForm]PetWriteDto petWriteDto)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await _shelterService.AddPetToShelter(petWriteDto);
			return Ok(result);
		}
	}
}
