using Application.ServiceAbstracts.UserServices;
using Domain.DTOs.WriteDTO;
using Infrastructure.InternalServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompanyController : ControllerBase
	{
		private readonly ICompanyService _companyService;

		public CompanyController(ICompanyService companyService)
		{
			_companyService = companyService;
		}


		[HttpGet("[action]")]
		[Authorize(Roles ="Company")]
		public async Task<IActionResult> GetCompanyProfileInfo(int id)
		{
			var company = await _companyService.GetCompanyProfileInfo(id);
			return Ok(company);
		}

		[HttpPost("[action]")]
		[Authorize(Roles ="Company")]
		public async Task<IActionResult> CreateShelter(ShelterWriteDto shelterWriteDto)
		{
			if (!ModelState.IsValid)
			{
				var errors = ModelState
					.Where(ms => ms.Value.Errors.Count > 0)
					.ToDictionary(
						ms => ms.Key,
						ms => ms.Value.Errors.Select(e => e.ErrorMessage).ToArray());

				return BadRequest(new { errors });
			}

			return Ok();
		}
	}
}
