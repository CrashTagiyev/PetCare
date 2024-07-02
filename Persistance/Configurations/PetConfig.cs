using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
	internal class PetConfig : IEntityTypeConfiguration<Pet>
	{
		public void Configure(EntityTypeBuilder<Pet> builder)
		{
			builder.HasOne(p => p.Shelter)
				.WithMany(sb => sb.Pets)
				.HasForeignKey(p => p.ShelterId).OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(p=>p.PetType)
				.WithMany(pt=>pt.Pets)
				.HasForeignKey(p=>p.PetTypeId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
