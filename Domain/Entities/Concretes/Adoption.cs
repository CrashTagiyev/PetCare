using Domain.Entities.Abstracts;
using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concretes
{
	public class Adoption : Entity
	{
		public int PetId { get; set; }
		public string UserId { get; set; }
		public int ShelterId { get; set; }

		public Pet Pet { get; set; }
		public Shelter Shelter { get; set; }
		public AppUser User { get; set; }
	}
}
