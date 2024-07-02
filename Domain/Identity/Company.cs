using Domain.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity
{
	public class Company:AppUser
	{
        public ICollection<Shelter> Shelters { get; set; }
	}
}
