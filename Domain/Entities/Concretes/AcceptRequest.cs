using Domain.Entities.Abstracts;
using Domain.Enums;
using Domain.Enums.EnumsExtensions;
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
		public Acceptstatus AcceptStatus { get; set; }
		public string Description { get; set; }

		//Foreign keys
		public int PetId { get; set; }
		public int UserId { get; set; }

		//Navigation properties
		public Pet Pet { get; set; }
		public AppUser User { get; set; }


	}
}
