using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concretes
{
	public class Breed:Entity
	{
		public string? BreedName { get; set; }

        public int PetTypeId { get; set; }
        //Property navigations
        public PetType? PetType { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
