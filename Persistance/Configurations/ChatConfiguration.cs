using Domain.Entities.Concretes;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
	public class ChatConfiguration : IEntityTypeConfiguration<Chat>
	{
		public void Configure(EntityTypeBuilder<Chat> builder)
		{


			builder
				.HasOne(u => u.User)
				.WithMany(u => u.Chats)
				.HasForeignKey(c => c.UserId)
				.OnDelete(DeleteBehavior.NoAction);

		
		}
	}
}
