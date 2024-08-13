using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations.IdentityConfigs
{
	public class RoleConfig : IEntityTypeConfiguration<IdentityRole<int>>
	{
		public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
		{
			builder.HasData(new IdentityRole<int>
			{
				Name = "User",
				NormalizedName = "USER"
			},
			new IdentityRole<int>
			{
				Name = "Vet",
				NormalizedName = "VET"
			},
			new IdentityRole<int>
			{
				Name = "Company",
				NormalizedName = "COMPANY"
			},
			new IdentityRole<int>
			{
				Name = "Admin",
				NormalizedName = "Admin"
			});
		}
	}
}
