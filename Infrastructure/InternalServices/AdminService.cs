using Application.ServiceAbstracts.UserServices;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.ReadDTO.AdminPanelDTOs;
using Domain.Identity;
using Domain.Models.AdminPanelModels.AdminControlModels;
using Domain.Models.AdminPanelModels.DashboardModels;
using Microsoft.AspNetCore.Identity;
using System.Net;

namespace Infrastructure.InternalServices
{
	public class AdminService : IAdminService
	{
		private readonly IPetReadRepository _petReadRepository;
		private readonly UserManager<AppUser> _userManager;
		private readonly IAppUserReadRepository _appUserReadRepository;
		private readonly IMapper _mapper;
		public AdminService(IPetReadRepository petReadRepository, UserManager<AppUser> userManager, IAppUserReadRepository appUserReadRepository, IMapper mapper)
		{
			_petReadRepository = petReadRepository;
			_userManager = userManager;
			_appUserReadRepository = appUserReadRepository;
			_mapper = mapper;
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

	
			#region AppUser services
		public async Task<List<AppUserReadAdminDTO>> GetUsersDatas(UsersFilterAdminModel filterModel)
		{
			var users = await _userManager.GetUsersInRoleAsync("User");
			var userDTOs = users.Select(_mapper.Map<AppUserReadAdminDTO>).ToList();
			return userDTOs;
		}

			#endregion

		public async Task<List<VetReadAdminDTO>> GetVetsDatas(VetFilterAdminModel filterModel)
		{
			var vets = await _userManager.GetUsersInRoleAsync("Vet");
			var vetDTOs = vets.Select(_mapper.Map<VetReadAdminDTO>).ToList();

			return vetDTOs;
		}
		public async Task<List<CompanyReadAdminDTO>> GetCompaniesDatas(CompanyFilterAdminModel filterModel)
		{
			var companies = await _userManager.GetUsersInRoleAsync("Company");
			var companyDTOs = companies.Select(_mapper.Map<CompanyReadAdminDTO>).ToList();
			return companyDTOs;
		}



		public async Task<HttpStatusCode> DeleteUser(int userId)
		{
			try
			{
				var user = await _appUserReadRepository.GetByIdAsync(userId);
				if (user is null)
					return HttpStatusCode.NotFound;

				await _userManager.DeleteAsync(user);
				return HttpStatusCode.OK;				
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

	}
}
