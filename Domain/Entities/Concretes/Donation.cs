using Domain.Entities.Abstracts;
using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concretes
{
	public class Donation : Entity
	{
		public decimal? Amount { get; set; }

		//foreign key
		public string ShelterId { get; set; }
		public string UserId { get; set; }
		
		//Navigation property
		public AppUser User { get; set; }
		public Shelter Shelter { get; set; }
	}
}
