using Domain.DTOs.ReadDTO.AdminPanelDTOs;
using Domain.Models.AdminPanelModels.AdminControlModels;
using Domain.Models.AdminPanelModels.DashboardModels;
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

		#endregion
		Task<List<VetReadAdminDTO>> GetVetsDatas(VetFilterAdminModel filterModel);
		Task<List<CompanyReadAdminDTO>> GetCompaniesDatas(CompanyFilterAdminModel filterModel);


		Task <HttpStatusCode> DeleteUser(int userId);


	}
}
