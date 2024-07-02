using Domain.Entities.Abstracts;
using Domain.Enums;
using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concretes
{
	public class AcceptRequest : Entity
	{
		public string? IsAccepted { get; set; } = Acceptstatus.Pending.ToString();
		public string? Description { get; set; }

		//Foreign keys
		public int PetId { get; set; }
		public string UserId { get; set; }

		//Navigation properties
		public Pet Pet { get; set; }
		public AppUser User { get; set; }

	}
}
