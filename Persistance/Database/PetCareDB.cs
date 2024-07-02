using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistance.Configurations;
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

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new AcceptRequestConfig());
			builder.ApplyConfiguration(new ShelterBranchConfig());
			builder.ApplyConfiguration(new AdoptionConfig());
			builder.ApplyConfiguration(new PetConfig());
			builder.ApplyConfiguration(new PetTypeConfig());
			builder.ApplyConfiguration(new BreedConfig());
			builder.ApplyConfiguration(new DonationConfig());
			builder.ApplyConfiguration(new LocationConfig());

			builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			base.OnModelCreating(builder);
		}

		

		public DbSet<Pet> Pets { get; set; }
		public DbSet<PetType> PetTypes { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Breed> Breeds { get; set; }
		public DbSet<AcceptRequest> AcceptRequests { get; set; }
		public DbSet<Donation> Donations { get; set; }
		public DbSet<ShelterBranch> ShelterBranches { get; set; }

	}
}
