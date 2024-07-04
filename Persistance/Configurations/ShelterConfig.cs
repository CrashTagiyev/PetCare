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

			//Properties
			builder.Property(s=>s.CompanyId).IsRequired();
			builder.Property(s=>s.LocationId).IsRequired();

		}
	}
}
