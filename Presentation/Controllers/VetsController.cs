using Application.ServiceAbstracts.UserServices;
using Domain.Models.EntityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VetsController : ControllerBase
	{
		private readonly IVetService _vetService;

		public VetsController(IVetService vetService)
		{
			_vetService = vetService;
		}

		[HttpGet("[action]")]
		[Authorize(Roles ="Vet,Admin")]
		public async Task<IActionResult> GetVet(int id)
		{
			var vet = await _vetService.GetVetInfoDTO(id);
			return Ok(vet);
		}
	
		[HttpPost("[action]")]
		public async Task<IActionResult> GetVetsList([FromBody]VetFilterModel vetFilterModel)
		{
			var vetsList = await _vetService.GetVetInfoDTOList();
			int totalVets = vetsList.Count();
			int skip = (vetFilterModel!.PageNumber - 1) * vetFilterModel.PageSize;
			vetsList = vetsList.Skip(skip).Take(vetFilterModel.PageSize).ToList();
			return Ok(new { vetsList, totalVets });
		}
	}
}
