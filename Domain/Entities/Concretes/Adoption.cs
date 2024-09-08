using Domain.Entities.Abstracts;
using Domain.Identity;


namespace Domain.Entities.Concretes
{
	public class Adoption : Entity
	{
		public int PetId { get; set; }
		public int UserId { get; set; }
		public string About { get; set; }
		public int YearsOfPetExperience { get; set; }
		public bool isAccepted { get; set; }
		public Pet Pet { get; set; }
		public AppUser User { get; set; }
	}
}
