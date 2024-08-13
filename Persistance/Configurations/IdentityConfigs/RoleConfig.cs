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
				Id = 1,
				Name = "User",
				NormalizedName = "USER"
			},
			new IdentityRole<int>
			{
				Id = 2,
				Name = "Vet",
				NormalizedName = "VET"
			},
			new IdentityRole<int>
			{
				Id = 3,
				Name = "Company",
				NormalizedName = "COMPANY"
			},
			new IdentityRole<int>
			{
				Id = 4,
				Name = "Admin",
				NormalizedName = "Admin"
			});
		}
	}
}
