using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concretes
{
	public class Pet : Entity
	{
		public string? PetName { get; set; }
		public string? Description { get; set; }
		public string? Size { get; set; }
		public short Age { get; set; }
		public string? Gender { get; set; }
		public string[]? ImageUrls { get; set; }
		public bool IsAdopted { get; set; } = false;
		public bool IsHealthy { get; set; }
		public decimal Weight { get; set; }

		//Foreign key
		public int PetTypeId { get; set; }
        public int SHelterBranchId { get; set; }
        //Navigation property
        public PetType? PetType { get; set; }
        public ShelterBranch?  ShelterBranch { get; set; }

	}
}
