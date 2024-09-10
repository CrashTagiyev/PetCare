using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	internal class PetTypeConfig : IEntityTypeConfiguration<PetType>
	{
		public void Configure(EntityTypeBuilder<PetType> builder)
		{
			//Properties
			builder.Property(pt => pt.TypeName).IsRequired();

			// Seed Data
			builder.HasData(
				new PetType { Id = 1, TypeName = "Dogs" },
				new PetType { Id = 2, TypeName = "Cats" },
				new PetType { Id = 3, TypeName = "Birds" },
				new PetType { Id = 4, TypeName = "Reptiles" },
				new PetType { Id = 5, TypeName = "Rodents" },
				new PetType { Id = 6, TypeName = "Fish" },
				new PetType { Id = 7, TypeName = "Farm Animals" },
				new PetType { Id = 8, TypeName = "Exotic Pets" }
			);
		}
	}
}
