using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concretes
{
	public class PetType:Entity
	{
        public string? TypeName { get; set; }
        
        //Property Navigations
        public ICollection<Breed>? Breeds { get; set; }
        public ICollection<Pet>? Pets { get; set; }
	}
}
