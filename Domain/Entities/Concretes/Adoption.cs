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
		public int UserId { get; set; }

		public Pet Pet { get; set; }
		public AppUser User { get; set; }
	}
}
