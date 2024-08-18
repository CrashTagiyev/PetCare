﻿using Domain.Entities.Abstracts;
using Domain.Identity;

namespace Domain.Entities.Concretes
{
	public class Shelter : Entity
	{

		//Foreign keys
		public int CompanyId { get; set; }
		public string? AboutShelter {  get; set; }
		public string? AdoptionPolicy { get; set; }

		//Navigation properties
		public virtual AppUser Company { get; set; }
		public virtual Location Location { get; set; }
		public ICollection<Pet> Pets { get; set; }



	}
}
