using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class ChatWriteRepository(PetCareDB context) : GenericRepository<Chat>(context), IChatWriteRepository
	{
		public async Task CreateAsync(Chat entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var chat = await _table.FirstOrDefaultAsync(c => c.Id == id);
			if (chat is not null)
			{
				_table.Remove(chat);
				await SaveChangesDbAsync();
			}

		}

		public Task UpdateAsync(Chat entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
