using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class Donation : Entity
	{
		public decimal? Amount { get; set; }

		//foreign key
		public int CompanyId { get; set; }
		public int UserId { get; set; }

		//Navigation
		public AppUser User { get; set; }
		public AppUser Company { get; set; }
	}
}
