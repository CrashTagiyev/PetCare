using Application.ServiceAbstracts.UserServices;
using Domain.DTOs.WriteDTO;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize(Roles = "Company,Admin")]
		public async Task<IActionResult> GetCompanyProfileInfo(int id)
		{
			var company = await _companyService.GetCompanyProfileInfo(id);
			return Ok(company);
		}

		[HttpPost("[action]")]
		[Authorize(Roles = "Company,Admin")]
		public async Task<IActionResult> CreateShelterAtCompany([FromForm] ShelterWriteDto shelterWriteDto)
		{
			var result = await _companyService.CreateShelter(shelterWriteDto);

			return Ok(result);
		}
		[HttpGet("[action]")]
		[Authorize(Roles = "Company,Admin")]
		public async Task<IActionResult> GetCompanyShelters(int companyId)
		{
			try
			{
				var shelters= await _companyService.GetCompanySheltersById(companyId);
				return Ok(shelters);
			}
			catch (Exception ex) 
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
