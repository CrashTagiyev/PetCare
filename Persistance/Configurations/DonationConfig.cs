using Domain.Entities.Concretes;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
	internal class DonationConfig : IEntityTypeConfiguration<Donation>
	{
		public void Configure(EntityTypeBuilder<Donation> builder)
		{
			builder.HasOne(d => d.User)
				.WithMany(u => u.Donations)
				.HasForeignKey(d => d.UserId);
		}
	}
}
