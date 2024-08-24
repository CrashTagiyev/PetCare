using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class Shelter : Entity
	{

		//Foreign keys
		public int CompanyId { get; set; }
		public string? ShelterName {  get; set; }
		public string? AboutShelter {  get; set; }
		public string? AdoptionPolicy { get; set; }
		public string? City { get; set; }
		public string? Address { get; set; }
		public string? ShelterImageUrl { get; set; }
		//Navigation properties
		public virtual AppUser Company { get; set; }
		public virtual ICollection<Pet> Pets { get; set; }



	}
}
