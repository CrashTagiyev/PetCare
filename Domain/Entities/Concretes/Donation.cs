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
		public string CompanyId { get; set; }
		public string UserId { get; set; }
		
		//Navigation
		public AppUser User { get; set; }
		public Company Company { get; set; }
	}
}
