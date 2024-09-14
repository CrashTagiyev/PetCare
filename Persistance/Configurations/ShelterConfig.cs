using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	public class ShelterConfig : IEntityTypeConfiguration<Shelter>
	{
		public void Configure(EntityTypeBuilder<Shelter> builder)
		{
			//Relations
			builder.HasOne(s => s.Company)
				.WithMany(s => s.Shelters)
				.HasForeignKey(sb => sb.CompanyId).OnDelete(DeleteBehavior.Cascade);

			//builder.HasOne(s => s.Location)
			//	.WithOne(l => l.Shelter)
			//	.HasForeignKey<Location>(l => l.ShelterId)
			//	.OnDelete(DeleteBehavior.Restrict);

			//Properties
			builder.Property(s => s.CompanyId).IsRequired();


			//seed datas
			var shelters = new List<Shelter>();

			// Seeding shelters for companies
			for (int i = 21; i <= 40; i++)
			{
				var shelter = new Shelter
				{
					Id = i + 1000,
					ShelterName =$"Shelter Name {i}",
					CompanyId = i + 2000, // Matching the CompanyId with the AppUser Id for companies
					AboutShelter = $"This is about shelter for Company{i}.",
					AdoptionPolicy = $"Adoption policy for Company{i}.",
					City = "Baku",
					Address = $"Street {i}",
					CreatedTime = DateTime.UtcNow,
					LastUpdatedTime = DateTime.UtcNow,
					IsDeleted = false,
					ShelterImageUrl= $"https://picsum.photos/seed/user{i}/200/300",
					PhoneNumber = "+994501234567",
					EmailAddress=$"ShelterEmailAddress{i}@gmail.com"
				};

				shelters.Add(shelter);
			}

			builder.HasData(shelters);
		}
	}
}
