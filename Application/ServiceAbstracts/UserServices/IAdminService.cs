using Domain.DTOs.AdminPanelDTOs;
using Domain.DTOs.AdminPanelDTOs.AppUserControlDTOs;
using Domain.DTOs.AdminPanelDTOs.CompanyControlDTOs;
using Domain.Models.AdminPanelModels.AdminControlModels;
using Domain.Models.AdminPanelModels.DashboardModels;
using Domain.Models.AuthModels.Request;
using System.Net;

namespace Application.ServiceAbstracts.UserServices
{
    public interface IAdminService
	{
		#region Dashboard interfaces
		public Task<List<MonthlyAddedEntitiesModel>> GetPetsCountByMonth();
		public Task<List<MonthlyAddedEntitiesModel>> GetRegisteredVetsCountByMonth();
		public Task<List<MonthlyAddedEntitiesModel>> GetRegisteredCompaniesCountByMonth();
		public Task<List<MonthlyAddedEntitiesModel>> GetRegisteredUsersCountByMonth();

		#endregion


		#region User controls

		Task<List<AppUserReadAdminDTO>> GetUsersDatas(UsersFilterAdminModel filterModel);
		Task<HttpStatusCode> CreateUser(RegisterRequest request);
		Task<AppUserReadAdminDTO> GetAppUserById(int userId);
		Task<HttpStatusCode> UpdateAppUser(AppUserUpdateAdminDTO updateAdminDTO);

		#endregion

		#region Vet control services
		
		Task<List<VetReadAdminDTO>> GetVetsDatas(VetFilterAdminModel filterModel);
		Task<HttpStatusCode> CreateVet(RegisterVetRequest registerVetRequest);

		#endregion

		#region Company control services

		Task<List<CompanyReadAdminDTO>> GetCompaniesDatas(CompanyFilterAdminModel filterModel);
		Task<HttpStatusCode> CreateCompany(RegisterCompanyRequest request);
		Task<HttpStatusCode> UpdateCompany(CompanyUpdateAdminDTO updateAdminDTO);
		Task<CompanyReadAdminDTO> GetCompany(int companyId);

		#endregion


		Task<HttpStatusCode> DeleteUser(int userId);


	}
}
