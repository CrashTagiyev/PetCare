using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Database
{
	public class PetCareDB : IdentityDbContext
	{
		public PetCareDB(DbContextOptions<PetCareDB> options)
			: base(options)
		{
		}

		public DbSet<Pet> Pets { get; set; }
		public DbSet<PetType> PetTypes { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Breed> Breeds { get; set; }
		public DbSet<AcceptRequest> AcceptRequests { get; set; }
		public DbSet<Donation> Donations { get; set; }

	}
}
