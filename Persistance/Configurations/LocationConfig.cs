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
			
			//Properties
			builder.Property(l => l.City).IsRequired();
			builder.Property(l => l.Region).IsRequired();
			builder.Property(l => l.ShelterId).IsRequired();

		}
	}
}
