using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	internal class LocationConfig : IEntityTypeConfiguration<Location>
	{
		public void Configure(EntityTypeBuilder<Location> builder)
		{
			//Relations
			builder.HasOne(l => l.Shelter)
				.WithOne(l => l.Location).OnDelete(DeleteBehavior.Cascade);

			//Properties
			builder.Property(l => l.City).IsRequired();
			builder.Property(l => l.Region).IsRequired();
			builder.Property(l => l.Street).IsRequired();

		}
	}
}
