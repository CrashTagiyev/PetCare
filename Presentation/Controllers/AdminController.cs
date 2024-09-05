using Application.ServiceAbstracts.UserServices;
using Domain.Models.AdminPanelModels.AdminControlModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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



		#region User Actions

		[HttpPost("[action]")]
		public async Task<IActionResult> AdminGetUsers([FromBody] UsersFilterAdminModel filterModel)
		{
			var userDTOs = await _adminService.GetUsersDatas(filterModel);

			int totalUsers = userDTOs.Count();
			int skip = (filterModel!.PageNumber - 1) * filterModel.PageSize;
			userDTOs = userDTOs.Skip(skip).Take(filterModel.PageSize).ToList();
			return Ok(new { usersList = userDTOs, totalUsers });
		}
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
		public async Task<IActionResult> AdminGetCompanies([FromBody] CompanyFilterAdminModel filterModel)
		{
			var companyDTOs = await _adminService.GetCompaniesDatas(filterModel);

			int totalCompanies = companyDTOs.Count();
			int skip = (filterModel!.PageNumber - 1) * filterModel.PageSize;
			companyDTOs = companyDTOs.Skip(skip).Take(filterModel.PageSize).ToList();

			return Ok(new { companiesList = companyDTOs, totalCompanies });
		}

		#endregion


	}
}
