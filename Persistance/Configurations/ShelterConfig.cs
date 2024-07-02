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
	public class ShelterConfig : IEntityTypeConfiguration<Shelter>
	{
		public void Configure(EntityTypeBuilder<Shelter> builder)
		{
			builder.HasOne(s => s.Company)
				.WithMany(s => s.Shelters)
				.HasForeignKey(sb => sb.CompanyId).OnDelete(DeleteBehavior.Cascade);


		
		}
	}
}
