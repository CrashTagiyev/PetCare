using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	internal class AdoptionConfig : IEntityTypeConfiguration<Adoption>
	{
		public void Configure(EntityTypeBuilder<Adoption> builder)
		{
			//Relations
			builder.HasOne(a => a.Pet)
				.WithMany(p => p.Adoptions)
				.HasForeignKey(a => a.PetId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(a => a.User)
				.WithMany(a => a.Adoptions)
				.HasForeignKey(u => u.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			//Properties
			builder.Property(a => a.PetId).IsRequired();
			builder.Property(a => a.UserId).IsRequired();

		}
	}
}
