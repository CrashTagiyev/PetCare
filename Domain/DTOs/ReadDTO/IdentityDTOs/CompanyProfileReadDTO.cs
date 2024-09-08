using Domain.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.ReadDTO.IdentityDTOs
{
	public class CompanyProfileReadDTO
	{
        public int Id { get; set; }
		public string? ProfileImageUrl { get; set; }
        public string? Email { get; set; }
        //Company
        public string? CompanyName { get; set; }
        
		//public virtual ICollection<Shelter>? Shelters { get; set; }

		//Vet/Company
		public string? About { get; set; } = string.Empty;



	}
}
