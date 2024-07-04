using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class Shelter : Entity
	{

		//Foreign keys
		public string CompanyId { get; set; }
		public int LocationId { get; set; }


		//Navigation properties
		public AppUser Company { get; set; }
		public Location Location { get; set; }
		public ICollection<Pet> Pets { get; set; }



	}
}
