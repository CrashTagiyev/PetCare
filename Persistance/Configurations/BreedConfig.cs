using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	internal class BreedConfig : IEntityTypeConfiguration<Breed>
	{
		public void Configure(EntityTypeBuilder<Breed> builder)
		{
			//Relations
			builder.HasOne(b => b.PetType)
				.WithMany(pt => pt.Breeds)
				.HasForeignKey(b => b.PetTypeId)
				.OnDelete(DeleteBehavior.Restrict);

			//Properties
			builder.Property(b => b.PetTypeId).IsRequired();
			builder.Property(b => b.BreedName).IsRequired();


			//Data seed

		}
	}
}
