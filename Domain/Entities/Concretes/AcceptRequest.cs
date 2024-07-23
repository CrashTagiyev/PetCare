using Domain.Entities.Abstracts;
using Domain.Enums;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class AcceptRequest : Entity
	{
		public Acceptstatus AcceptStatus { get; set; }
		public string Description { get; set; }
		public int YearsOfPetExperience { get; set; }
		//Foreign keys
		public int PetId { get; set; }
		public int UserId { get; set; }

		//Navigation properties
		public Pet Pet { get; set; }
		public AppUser User { get; set; }


	}
}
