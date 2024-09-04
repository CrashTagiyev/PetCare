namespace Domain.Models.AdminPanelModels.DashboardModels
{
	public class MonthlyAddedEntitiesModel
	{
		public string YearMonth { get; set; }
		public int Count { get; set; }
		public MonthlyAddedEntitiesModel(string yearMonth, int count)
		{
			YearMonth = yearMonth;
			Count = count;
		}
	}
}
