using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Persistance.Configurations
{
	public class MessageConfiguration : IEntityTypeConfiguration<Message>
	{
		public void Configure(EntityTypeBuilder<Message> builder)
		{

			builder
				.HasOne(m => m.Chat)
				.WithMany(c => c.Messages)
				.HasForeignKey(m => m.ChatId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.HasOne(m => m.Sender)
				.WithMany(u => u.Messages)
				.HasForeignKey(m => m.SenderId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
