using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class MessageWriteRepository(PetCareDB context) : GenericRepository<Message>(context), IMessageWriteRepository
	{
		public async Task CreateAsync(Message entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var message = await _table.FirstOrDefaultAsync(m => m.Id == id);
			_table.Remove(message);
			await SaveChangesDbAsync();
		}

		public async Task UpdateAsync(Message entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}
	}
}
