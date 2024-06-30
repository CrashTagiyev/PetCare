using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concretes
{
	public class Location:Entity
	{
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? Street { get; set; }



        //Foreign key
        //Navigation peroperties
        public ShelterBranch  ShelterBranch { get; set; }

    }
}
