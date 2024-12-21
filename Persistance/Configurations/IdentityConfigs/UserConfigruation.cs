using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations.IdentityConfigs
{
	public class UserConfigruation : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{

			var users = new List<AppUser>();

			var random = new Random();
			var admin = new AppUser
			{
				Id  =9999,
				DateOfBirth = new DateTime(1999, 12, 31).AddDays(1), // Slightly varying DOB
				City = $"Baku",
				Address = $"Koroglu Rahimov 70",
				CreatedTime = DateTime.UtcNow,
				LastUpdatedTime = DateTime.UtcNow,
				IsDeleted = false,
				EmailConfirmed = true,
				About = $"Somme about text for something bla bla bla",
				PasswordHash = "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==",
				SecurityStamp = "RYZH37KPG6EEDGSYWW37NETRG56JM7KG",
				ProfileImageUrl = $"https://picsum.photos/seed/user{1}/200/300",
				UserName="PetCareAdmin",
				NormalizedUserName="PETCAREADMIN",
				Email="crashtagiyev@gmail.com",
				NormalizedEmail="CRASHTAGIYEV@GMAIL.COM",
				PhoneNumber= "+993509998485"

			};
			users.Add(admin);
			for (int i = 1; i <= 60; i++)
			{
				var user = new AppUser
				{
					Id = i + 2000,
					DateOfBirth = new DateTime(1999, 12, 31).AddDays(i), 
					City = $"Baku",
					Address = $"Koroglu Rahimov 70",
					CreatedTime = DateTime.UtcNow.AddMonths(-random.Next(1, 12)),
					LastUpdatedTime = DateTime.UtcNow,
					IsDeleted = false,
					EmailConfirmed = true,
					About=$"Somme about text for something bla bla bla",
					PasswordHash= "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==",
					SecurityStamp= "RYZH37KPG6EEDGSYWW37NETRG56JM7KG",
					PhoneNumber = "+993509998485",
					ProfileImageUrl = $"https://picsum.photos/seed/user{i}/200/300" // Using Lorem Picsum for random images
				};
				if (i <= 20)
				{
					user.UserName = $"user{i}";
					user.NormalizedUserName = $"USER{i}";
					user.Email = $"user{i}@example.com";
					user.NormalizedEmail = $"USER{i}@EXAMPLE.COM";
					user.Firstname = $"FirstName{i}";
					user.Lastname = $"LastName{i}";
				}
				else if (i <= 40)
				{

					user.UserName = $"Company{i}";
					user.NormalizedUserName = $"COMPANY{i}";
					user.Email = $"Company{i}@example.com";
					user.NormalizedEmail = $"COMPANY{i}@EXAMPLE.COM";
					user.Firstname = $"CompanyFirstName{i}";
					user.Lastname = $"CompanyLastName{i}";
					user.CompanyName = $"Company Name{i}";
				}
				else if (i <= 60)
				{

					user.UserName = $"Vet{i}";
					user.NormalizedUserName = $"VET{i}";
					user.Email = $"Vet{i}@example.com";
					user.NormalizedEmail = $"VET{i}@EXAMPLE.COM";
					user.Firstname = $"VetFirstName{i}";
					user.Lastname = $"VetLastName{i}";
				}
				users.Add(user);
			}

			builder.HasData(users);
		}
	}
}
