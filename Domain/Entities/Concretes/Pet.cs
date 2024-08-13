using Domain.Entities.Abstracts;
using Domain.Enums;
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
		public Gender? Gender { get; set; }
		public string[]? ImageUrls { get; set; }
		public bool IsAdopted { get; set; } = false;
		public string Health { get; set; }
		public decimal Weight { get; set; }
		public int BreedId { get; set; }

		//Foreign key
		public int PetTypeId { get; set; }
        public int ShelterId { get; set; }
        public int? AdoptionId { get; set; }
        //Navigation property
        public PetType PetType { get; set; }
        public Shelter  Shelter { get; set; }
		public Adoption?  Adoption { get; set; }	

		public ICollection<AcceptRequest> AcceptRequests { get; set; }

	}
}
