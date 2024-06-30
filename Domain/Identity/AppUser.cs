using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Identity;


namespace Domain.Identity
{
	public class AppUser : IdentityUser
	{
		public string? Firstname { get; set; }
		public string? Lasname { get; set; }
		public DateTime? DateOfBirth { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }

		//Navigation properties
		public ICollection<Donation>? Donations { get; set; }
		//public ICollection<AcceptRequest>? AcceptRequests { get; set; }
		//      public ICollection<Adoption>? Adoptions { get; set; }
		//public ICollection<ShelterBranch>? ShelterBranches { get; set; }

	}
}
