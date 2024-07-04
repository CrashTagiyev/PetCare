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
		}
	}
}
