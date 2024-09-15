using System.Net;
using Application.ServiceAbstracts;
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
		private readonly IAdoptService _adoptService;


		public CompanyController(ICompanyService companyService, IAdoptService adoptService)
		{
			_companyService = companyService;
			_adoptService = adoptService;
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
		
		[HttpGet("[action]")]

		public async Task<IActionResult> GetCompanyAdoptions(int companyId)
		{
			try
			{
				var adoptions = await _companyService.GetAdoptionsForCompanyAsync(companyId);
				return Ok(new {requestsArray=adoptions});
			}
			catch(Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> HandleRequest(int adoptionId,bool response)
		{
			try
			{
				var result = await _adoptService.HandleAdoptRequest(adoptionId, response);
				if (result == HttpStatusCode.NotFound)
					return NotFound("Adoption is not found");
				else if (result == HttpStatusCode.NotModified)
					return Ok("Adoption is not accepted");
				
				return Ok("Adoption is accepted");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}
