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
		}
	}
}
