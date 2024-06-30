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
	internal class BreedConfig : IEntityTypeConfiguration<Breed>
	{
		public void Configure(EntityTypeBuilder<Breed> builder)
		{
		}
	}
}
