using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class PetType : Entity
	{
		public string? TypeName { get; set; }

		public ICollection<Breed>? Breeds { get; set; }

		//Property Navigations
		public ICollection<Pet>? Pets { get; set; }
		public ICollection<AppUser> Vets { get; set; }
	}
}
