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
				.HasForeignKey(sb => sb.CompanyId).OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(s => s.Location)
				.WithOne(l => l.Shelter)
				.HasForeignKey<Location>(l => l.ShelterId)
				.OnDelete(DeleteBehavior.Restrict);

			//Properties
			builder.Property(s => s.CompanyId).IsRequired();

		}
	}
}
