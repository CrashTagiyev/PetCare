﻿using Domain.Entities.Concretes;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistance.Configurations;

namespace Persistance.Database
{
	public class PetCareDB : IdentityDbContext<AppUser, IdentityRole<int>,int>
	{
		public PetCareDB(DbContextOptions<PetCareDB> options)
			: base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new AcceptRequestConfig());
			builder.ApplyConfiguration(new ShelterConfig());
			builder.ApplyConfiguration(new AdoptionConfig());
			builder.ApplyConfiguration(new PetConfig());
			builder.ApplyConfiguration(new PetTypeConfig());
			builder.ApplyConfiguration(new BreedConfig());
			builder.ApplyConfiguration(new DonationConfig());
			builder.ApplyConfiguration(new LocationConfig());
			builder.ApplyConfiguration(new MessageConfiguration());
			builder.ApplyConfiguration(new ChatConfiguration());



			//builder.Entity<Pet>().HasQueryFilter(p => !p.IsDeleted);
			//builder.Entity<Pet>().HasQueryFilter(p => !p.IsAdopted);
			//builder.Entity<Shelter>().HasQueryFilter(p => !p.IsDeleted);
			//builder.Entity<PetType>().HasQueryFilter(p => !p.IsDeleted);
			//builder.Entity<Breed>().HasQueryFilter(p => !p.IsDeleted);
			//builder.Entity<Donation>().HasQueryFilter(p => !p.IsDeleted);
			//builder.Entity<Location>().HasQueryFilter(p => !p.IsDeleted);
			//builder.Entity<Adoption>().HasQueryFilter(p => !p.IsDeleted);
			//builder.Entity<AcceptRequest>().HasQueryFilter(p => !p.IsDeleted);

			base.OnModelCreating(builder);
		}



		public DbSet<Pet> Pets { get; set; }
		public DbSet<PetType> PetTypes { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Breed> Breeds { get; set; }
		public DbSet<Adoption> Adoptions { get; set; }
		public DbSet<AcceptRequest> AcceptRequests { get; set; }
		public DbSet<Donation> Donations { get; set; }
		public DbSet<Shelter> Shelters { get; set; }
		public DbSet<Chat> Chats { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Notification> Notifications { get; set; }

	}
}
