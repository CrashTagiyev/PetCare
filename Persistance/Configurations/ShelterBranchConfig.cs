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
	public class ShelterBranchConfig : IEntityTypeConfiguration<ShelterBranch>
	{
		public void Configure(EntityTypeBuilder<ShelterBranch> builder)
		{
			builder.HasOne(sb => sb.Shelter)
				.WithMany(s => s.ShelterBranches)
				.HasForeignKey(sb => sb.ShelterId);

		
		}
	}
}
