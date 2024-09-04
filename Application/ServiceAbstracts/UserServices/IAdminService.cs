using Domain.Models.AdminPanelModels.DashboardModels;

namespace Application.ServiceAbstracts.UserServices
{
	public interface IAdminService
	{

		public Task<List<MonthlyAddedEntitiesModel>> GetPetsCountByMonth();
		public Task<List<MonthlyAddedEntitiesModel>> GetRegisteredVetsCountByMonth();
		public Task<List<MonthlyAddedEntitiesModel>> GetRegisteredCompaniesCountByMonth();
		public Task<List<MonthlyAddedEntitiesModel>> GetRegisteredUsersCountByMonth();
	}
}
