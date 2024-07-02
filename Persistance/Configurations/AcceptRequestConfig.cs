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
	public class AcceptRequestConfig : IEntityTypeConfiguration<AcceptRequest>
	{
		public void Configure(EntityTypeBuilder<AcceptRequest> builder)
		{
			builder.HasOne(ar => ar.Pet)
				.WithMany(p => p.AcceptRequests)
				.HasForeignKey(ar => ar.PetId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(ar => ar.User)
				.WithMany(u => u.AcceptRequests)
				.HasForeignKey(u => u.UserId)
				.OnDelete(DeleteBehavior.NoAction);



		}
	}
}
