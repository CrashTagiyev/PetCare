using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations.IdentityConfigs
{
	public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<int>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
		{
			var usersRoles = new List<IdentityUserRole<int>>();
			for (int i = 0; i <= 60; i++)
			{
				if (i > 0)
				{
					var userRole = new IdentityUserRole<int>();
					userRole.UserId = i + 2000;
					if (i <= 20)
						userRole.RoleId = 1;
					else if (i < 40)
						userRole.RoleId = 3;
					else
						userRole.RoleId = 2;
					usersRoles.Add(userRole);
				}
			}
			builder.HasData(usersRoles);
		}
	}
}
