using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class ShelterBranch : Entity
	{
		public string ShelterId { get; set; }
		public int LocationId { get; set; }
		public Shelter Shelter { get; set; }
		public Location Location { get; set; }
		public ICollection<Pet> Pets { get; set; }
	}
}
