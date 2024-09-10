using Application.ServiceAbstracts;
using Application.ServiceAbstracts.UserServices;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.ReadDTO.AdminPanelDTOs;
using Domain.DTOs.ReadDTO.AdminPanelDTOs.AppUserControlDTOs;
using Domain.Identity;
using Domain.Models.AdminPanelModels.AdminControlModels;
using Domain.Models.AdminPanelModels.DashboardModels;
using Domain.Models.AuthModels.Request;
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
		private readonly IBlobService _blobService;
		public AdminService(IPetReadRepository petReadRepository, UserManager<AppUser> userManager, IAppUserReadRepository appUserReadRepository, IMapper mapper, IBlobService blobService)
		{
			_petReadRepository = petReadRepository;
			_userManager = userManager;
			_appUserReadRepository = appUserReadRepository;
			_mapper = mapper;
			_blobService = blobService;
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

		//---------------------------------------------------
		#region AppUser services
		public async Task<List<AppUserReadAdminDTO>> GetUsersDatas(UsersFilterAdminModel filterModel)
		{
			var users = await _userManager.GetUsersInRoleAsync("User");
			var userDTOs = users.Select(_mapper.Map<AppUserReadAdminDTO>).ToList();
			return userDTOs;
		}

		public async Task<AppUserReadAdminDTO> GetAppUserById(int userId)
		{
			try
			{
				var user = await _appUserReadRepository.GetByIdAsync(userId);
				if (user is null)
					throw new Exception($"App user did not found by this id {userId}");

				return _mapper.Map<AppUserReadAdminDTO>(user);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public async Task<HttpStatusCode> CreateUser(RegisterRequest request)
		{
			var user = _mapper.Map<AppUser>(request);
			user.EmailConfirmed = true;

			if (request.ProfileImage is not null)
				user.ProfileImageUrl = await _blobService.UploadImageFileAsync(request.ProfileImage);

			var result = await _userManager.CreateAsync(user, request.Password!);

			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, "User");

				return HttpStatusCode.OK;
			}

			return HttpStatusCode.BadRequest;
		}
		public async Task<HttpStatusCode> UpdateAppUser(AppUserUpdateAdminDTO updateAdminDTO)
		{
			try
			{

				var user = await _appUserReadRepository.GetByIdAsync(updateAdminDTO.Id);
				if (user is null)
					return HttpStatusCode.NotFound;

				_mapper.Map(updateAdminDTO, user, typeof(AppUserUpdateAdminDTO), typeof(AppUser));

				if (updateAdminDTO.ProfileImage is not null)
				{
					var imageDeletingStatusCode = await _blobService.DeleteImageFileAsync(user.ProfileImageUrl!);
					var newImageUrl = await _blobService.UploadImageFileAsync(updateAdminDTO.ProfileImage);
					user.ProfileImageUrl = newImageUrl;
				}

				var result = await _userManager.UpdateAsync(user);

				if (result.Succeeded)
					return HttpStatusCode.OK;

				return HttpStatusCode.InternalServerError;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}


		#endregion


		//-------------------------------------

		#region Vet services


		public async Task<List<VetReadAdminDTO>> GetVetsDatas(VetFilterAdminModel filterModel)
		{
			var vets = await _userManager.GetUsersInRoleAsync("Vet");
			var vetDTOs = vets.Select(_mapper.Map<VetReadAdminDTO>).ToList();

			return vetDTOs;
		}
		#endregion


		#region Company services
		public async Task<List<CompanyReadAdminDTO>> GetCompaniesDatas(CompanyFilterAdminModel filterModel)
		{
			var companies = await _userManager.GetUsersInRoleAsync("Company");
			var companyDTOs = companies.Select(_mapper.Map<CompanyReadAdminDTO>).ToList();
			return companyDTOs;
		}

		public async Task<HttpStatusCode> CreateCompany(RegisterCompanyRequest request)
		{
			try
			{

				var newCompany = _mapper.Map<AppUser>(request);

				if (request.ProfileImage is not null)
					newCompany.ProfileImageUrl = await _blobService.UploadImageFileAsync(request.ProfileImage);

				newCompany.EmailConfirmed = true;
				var result = await _userManager.CreateAsync(newCompany, request.Password!);

				if (result.Succeeded)
				{
					await _userManager.AddToRoleAsync(newCompany, "Company");
					return HttpStatusCode.Created;
				}

				return HttpStatusCode.BadRequest;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		#endregion

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
