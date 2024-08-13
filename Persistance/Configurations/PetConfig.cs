using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	internal class PetConfig : IEntityTypeConfiguration<Pet>
	{
		public void Configure(EntityTypeBuilder<Pet> builder)
		{
			//Relations
			builder.HasOne(p => p.Shelter)
				.WithMany(sb => sb.Pets)
				.HasForeignKey(p => p.ShelterId).OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(p => p.PetType)
				.WithMany(pt => pt.Pets)
				.HasForeignKey(p => p.PetTypeId).OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(p => p.Adoption)
				.WithOne(a => a.Pet)
				.OnDelete(DeleteBehavior.Restrict);

			//Properties
			builder.Property(p => p.Age).IsRequired();
			builder.Property(p => p.Gender).IsRequired();
			builder.Property(p => p.PetName).IsRequired();
			builder.Property(p => p.Description).IsRequired();
			builder.Property(p => p.Age).IsRequired();
			builder.Property(p => p.Health).IsRequired();
			builder.Property(p => p.ShelterId).IsRequired();
		}
	}
}
