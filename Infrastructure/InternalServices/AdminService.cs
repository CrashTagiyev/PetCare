using Application.ServiceAbstracts.UserServices;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Identity;
using Domain.Models.AdminPanelModels.DashboardModels;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.InternalServices
{
	public class AdminService : IAdminService
	{
		private readonly IPetReadRepository _petReadRepository;
		private readonly UserManager<AppUser> _userManager;
		public AdminService(IPetReadRepository petReadRepository, UserManager<AppUser> userManager)
		{
			_petReadRepository = petReadRepository;
			_userManager = userManager;
		}


		#region Dashboard services


		public async Task<List<MonthlyAddedEntitiesModel>> GetPetsCountByMonth()
		{
			var pets = await _petReadRepository.GetAllAsync();
			var groupedPets = pets
			.Where(p => !p.IsDeleted)
			.GroupBy(p => new { p.CreatedTime.Year, p.CreatedTime.Month })
			.Select(g => new MonthlyAddedEntitiesModel(
				$"{g.Key.Year}-{g.Key.Month:D2}",
				g.Count()
			))
			.OrderBy(g => g.YearMonth)
			.ToList();

			return groupedPets;
		}

		public async Task<List<MonthlyAddedEntitiesModel>> GetRegisteredCompaniesCountByMonth()
		{
			var companies = await _userManager.GetUsersInRoleAsync("Company");
			var groupedCompanies = companies
			.Where(p => !p.IsDeleted)
			.GroupBy(p => new { p.CreatedTime.Year, p.CreatedTime.Month })
			.Select(g => new MonthlyAddedEntitiesModel(
				$"{g.Key.Year}-{g.Key.Month:D2}",
				g.Count()
			))
			.OrderBy(g => g.YearMonth)
			.ToList();

			return groupedCompanies;
		}

		public async Task<List<MonthlyAddedEntitiesModel>> GetRegisteredUsersCountByMonth()
		{
			var users = await _userManager.GetUsersInRoleAsync("User");
			var groupedUsers = users
			.Where(p => !p.IsDeleted)
			.GroupBy(p => new { p.CreatedTime.Year, p.CreatedTime.Month })
			.Select(g => new MonthlyAddedEntitiesModel(
				$"{g.Key.Year}-{g.Key.Month:D2}",
				g.Count()
			))
			.OrderBy(g => g.YearMonth)
			.ToList();

			return groupedUsers;
		}

		public async Task<List<MonthlyAddedEntitiesModel>> GetRegisteredVetsCountByMonth()
		{
			var vets = await _userManager.GetUsersInRoleAsync("Vet");
			var groupedVets = vets
			.Where(p => !p.IsDeleted)
			.GroupBy(p => new { p.CreatedTime.Year, p.CreatedTime.Month })
			.Select(g => new MonthlyAddedEntitiesModel(
				$"{g.Key.Year}-{g.Key.Month:D2}",
				g.Count()
			))
			.OrderBy(g => g.YearMonth)
			.ToList();

			return groupedVets;
		}
		
		#endregion


	}
}
