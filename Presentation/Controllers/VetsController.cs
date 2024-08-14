using Application.ServiceAbstracts.UserServices;
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
		public async Task<IActionResult> GetVet(int id)
		{
			var vet = await _vetService.GetVetInfoDTO(id);
			return Ok(vet);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetVetsList(int id)
		{
			var vetsList = await _vetService.GetVetInfoDTOList();
			return Ok(vetsList);
		}
	}
}
