using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
	public class ChatReadRepository : GenericRepository<Chat>, IChatReadRepository
	{
		public ChatReadRepository(PetCareDB context) : base(context)
		{
		}

		public async Task<ICollection<Chat>> GetAllAsync()
		{
			return await _table.ToListAsync();
		}

		public async Task<Chat?> GetByIdAsync(int id)
		{
			return await _table.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<Chat?> GetChatByChatName(string chatName)
		{
			return await _table.FirstOrDefaultAsync(c => c.ChatName == chatName);
		}

		public async Task<Chat?> GetChatByNameAndReverseName(string chatName)
		{
			var splitGroupName = chatName.Split('+');
			var reverseGroupName = string.Join("+", splitGroupName.Reverse());
			var chat = await _table.Include(c => c.Messages).FirstOrDefaultAsync(c => c.ChatName == reverseGroupName || c.ChatName == chatName);
			return chat;
		}

		public async Task<ICollection<Chat>> GetUserChats(string userName)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
			if (user is not null)
				return await _table.Include(c => c.User).Include(c => c.Vet).Where(c => c.UserId == user!.Id || c.VetId == user!.Id).ToListAsync();
			return Enumerable.Empty<Chat>().ToList();
		}
	}
}
