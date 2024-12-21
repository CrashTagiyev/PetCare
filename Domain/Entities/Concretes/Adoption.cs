using Domain.Entities.Abstracts;
using Domain.Enums;
using Domain.Identity;


namespace Domain.Entities.Concretes
{
	public class Adoption : Entity
	{
		public int PetId { get; set; }
		public int UserId { get; set; }
		public string About { get; set; }
		public int YearsOfPetExperience { get; set; }
		public Acceptstatus isAccepted { get; set; } = Acceptstatus.Pending;
		public Pet Pet { get; set; }
		public AppUser User { get; set; }
	}
}
