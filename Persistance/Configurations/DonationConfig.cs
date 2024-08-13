using Domain.Entities.Concretes;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
	internal class DonationConfig : IEntityTypeConfiguration<Donation>
	{
		public void Configure(EntityTypeBuilder<Donation> builder)
		{
			//Relations
			builder.HasOne(u=>u.User)
				.WithMany(u => u.Donations)
				.HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.NoAction);

			

			//Properties
			builder.Property(d => d.UserId).IsRequired();
			builder.Property(d => d.CompanyId).IsRequired();
			builder.Property(d => d.Amount).IsRequired();

		}
	}
}
