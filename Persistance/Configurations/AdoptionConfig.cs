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
	internal class AdoptionConfig : IEntityTypeConfiguration<Adoption>
	{
		public void Configure(EntityTypeBuilder<Adoption> builder)
		{
			builder.HasOne(a => a.Pet)
		.WithOne(p => p.Adoption)
		.HasForeignKey<Adoption>(a => a.PetId) 
		.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(a=>a.User)
				.WithMany(a=>a.Adoptions)
				.HasForeignKey(u=>u.UserId)
				.OnDelete(DeleteBehavior.Cascade);

		}
	}
}
