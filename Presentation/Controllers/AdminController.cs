using Application.ServiceAbstracts.UserServices;
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


	}
}
