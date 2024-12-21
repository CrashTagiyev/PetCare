using System.Net;
using Application.ServiceAbstracts;
using Application.ServiceAbstracts.UserServices;
using Domain.DTOs.WriteDTO;
using Domain.Enums;
using Domain.Models.EntityModels;
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
		public async Task<IActionResult> HandleRequest([FromBody]AdoptionRequestHandlerModel adoptionRequestHandlerModler)
		{
			try
			{
				var result = await _adoptService.HandleAdoptRequest(adoptionRequestHandlerModler.AdoptionId, adoptionRequestHandlerModler.Response);
				if (result is not null)
				{
					if (result.isAccepted == Acceptstatus.Accepted)
						return Ok("Your adoption request is accepted");
					else if (result.isAccepted == Acceptstatus.Denied)
						return Ok("Your adoption request is rejected");
				}

				return BadRequest("Invalid adoption request");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}
