using Application.ServiceAbstracts.UserServices;
using Domain.DTOs.AdminPanelDTOs.AppUserControlDTOs;
using Domain.DTOs.AdminPanelDTOs.CompanyControlDTOs;
using Domain.DTOs.AdminPanelDTOs.ShelterControlDTOs;
using Domain.Models.AdminPanelModels.AdminControlModels;
using Domain.Models.AuthModels.Request;
using Domain.Models.EntityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Net;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize(Roles = "Admin")]
	public class AdminController : ControllerBase
	{
		private readonly IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}

		#region Dashboard actions

		[HttpGet("[action]")]
		public async Task<IActionResult> PetsMonthly()
		{
			var petsCount = await _adminService.GetPetsCountByMonth();
			return Ok(petsCount);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> RegisteredVetsMonthly()
		{
			var vetsCount = await _adminService.GetRegisteredVetsCountByMonth();
			return Ok(vetsCount);
		}
		[HttpGet("[action]")]
		public async Task<IActionResult> RegisteredCompaniesMonthly()
		{
			var companiesCount = await _adminService.GetRegisteredCompaniesCountByMonth();
			return Ok(companiesCount);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> RegisteredUsersMonthly()
		{
			var usersCount = await _adminService.GetRegisteredUsersCountByMonth();
			return Ok(usersCount);
		}
		#endregion



		#region AppUser control Actions

		[HttpPost("[action]")]
		public async Task<IActionResult> GetAppUsers([FromBody] UsersFilterAdminModel filterModel)
		{
			var userDTOs = await _adminService.GetUsersDatas(filterModel);

			int totalUsers = userDTOs.Count();
			int skip = (filterModel!.PageNumber - 1) * filterModel.PageSize;
			userDTOs = userDTOs.Skip(skip).Take(filterModel.PageSize).ToList();
			return Ok(new { usersList = userDTOs, totalUsers });
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateAppUser([FromForm] RegisterRequest registerRequest)
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

			var result = await _adminService.CreateUser(registerRequest);
			if (result != HttpStatusCode.OK)
			{
				return BadRequest(new { errors = "Something is wrong. Account is not created" });
			}

			return Ok(new { statusCode = result, statusMessage = "Account created successfully" });
		}


		[HttpGet("[action]")]
		public async Task<IActionResult> GetAppUser([FromQuery] int userId)
		{
			var userDTO = await _adminService.GetAppUserById(userId);
			return Ok(userDTO);
		}

		[HttpPut("[action]")]
		public async Task<IActionResult> UpdateAppUser([FromForm] AppUserUpdateAdminDTO updateAdminDTO)
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

			var statusCode = await _adminService.UpdateAppUser(updateAdminDTO);
			if (statusCode is HttpStatusCode.NotFound)
				return NotFound(new { statusCode, statusMessage = $"App user with this id:{updateAdminDTO.Id} did not found" });

			if (statusCode is HttpStatusCode.InternalServerError)
				return NotFound(new { statusCode, statusMessage = $"Internal server error occurced" });


			return Ok(new { statusCode, statusMessage = "App user updated successfuly" });


		}


		#endregion



		#region Vet control actions

		[HttpPost("[action]")]
		public async Task<IActionResult> AdminGetVets([FromBody] VetFilterAdminModel filterModel)
		{
			var vetDTOs = await _adminService.GetVetsDatas(filterModel);

			int totalVets = vetDTOs.Count();
			int skip = (filterModel!.PageNumber - 1) * filterModel.PageSize;
			vetDTOs = vetDTOs.Skip(skip).Take(filterModel.PageSize).ToList();

			return Ok(new { vetsList = vetDTOs, totalVets });
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AdminCreateVet([FromForm] RegisterVetRequest registerVetRequest)
		{

			var statusCode = await _adminService.CreateVet(registerVetRequest);

			if (statusCode is HttpStatusCode.InternalServerError)
				return BadRequest(new { message = "Internal server error", statusCode });

			return Ok(new { message = "Account is successfully create", statusCode });
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> AdminGetVetById(int vetId)
		{
			var vet = await _adminService.GetVetById(vetId);
			return Ok(vet);
		}

		#endregion

		#region Company control Actions

		[HttpPost("[action]")]
		public async Task<IActionResult> AdminGetCompanies([FromBody] CompanyFilterAdminModel filterModel)
		{
			var companyDTOs = await _adminService.GetCompaniesDatas(filterModel);

			int totalCompanies = companyDTOs.Count();
			int skip = (filterModel!.PageNumber - 1) * filterModel.PageSize;
			companyDTOs = companyDTOs.Skip(skip).Take(filterModel.PageSize).ToList();

			return Ok(new { companiesList = companyDTOs, totalCompanies });
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AdminCreateCompany([FromForm] RegisterCompanyRequest request)
		{
			var statusCode = await _adminService.CreateCompany(request);
			if (statusCode is HttpStatusCode.Created)
				return Ok("Account successfully created");

			return BadRequest(statusCode);
		}


		[HttpGet("[action]")]
		public async Task<IActionResult> GetCompany([FromQuery] int companyId)
		{
			var companyDTO = await _adminService.GetCompany(companyId);

			if (companyDTO is null)
				return NotFound("Company with this id did not found!");

			return Ok(companyDTO);
		}



		[HttpPut("[action]")]
		public async Task<IActionResult> UpdateCompany([FromForm] CompanyUpdateAdminDTO updateAdminDTO)
		{

			var statusCode = await _adminService.UpdateCompany(updateAdminDTO);
			if (statusCode is HttpStatusCode.NotFound)
				return NotFound(new { statusCode, statusMessage = $"Company with this id:{updateAdminDTO.Id} did not found" });

			if (statusCode is HttpStatusCode.InternalServerError)
				return NotFound(new { statusCode, statusMessage = $"Internal server error occurced" });


			return Ok(new { statusCode, statusMessage = "Company updated successfuly" });


		}

		#endregion

		#region Shelter control actions
		[HttpPost("[action]")]
		public async Task<IActionResult> GetShelters(ShelterFilterModel filterModel)
		{
			var shelterDTOs=await _adminService.GetShelters();

			int totalShelters = shelterDTOs.Count();
			int skip = (filterModel!.PageNumber - 1) * filterModel.PageSize;
			var sheltersList = shelterDTOs.Skip(skip).Take(filterModel.PageSize).ToList();

			return Ok(new { sheltersList, totalShelters });

		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetShelterById(int id)
		{
			var shelterDTOs = await _adminService.GetShelterById(id);
			return Ok(shelterDTOs);
		}

		[HttpPut("[action]")]
		public async Task<IActionResult> UpdateShelter(ShelterUpdateAdminDTO shelter)
		{
			var statusCode = await _adminService.UpdateShelter(shelter);
			return Ok(statusCode);
		}


		#endregion

		[HttpDelete("[action]")]
		public async Task<IActionResult> DeleteAppUser([FromQuery] int id)
		{
			var statusCode = await _adminService.DeleteUser(id);
			return Ok(statusCode);
		}


	}
}
