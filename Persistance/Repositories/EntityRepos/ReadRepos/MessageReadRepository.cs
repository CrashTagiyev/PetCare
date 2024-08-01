using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
	public class MessageReadRepository : GenericRepository<Message>, IMessageReadRepository
	{
		public MessageReadRepository(PetCareDB context) : base(context)
		{
		}

		public async Task<ICollection<Message>> GetAllAsync()
		{
			return await _table.ToListAsync();
		}

		public async Task<Message?> GetByIdAsync(int id)
		{
			return await _table.FirstOrDefaultAsync(m => m.Id == id);
		}

		public async Task<ICollection<Message>> GetMessagesByChatName(string chatName)
		{
			return await _table.Include(m => m.Sender).Include(m => m.Chat).Where(m => m.Chat.ChatName.Contains(chatName)).ToListAsync();
		}
	}
}
