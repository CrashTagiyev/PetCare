using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class ShelterWriteRepository : GenericRepository<Shelter>, IShelterWriteRepository
	{
		public ShelterWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Shelter entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var shelter = await _table.FirstOrDefaultAsync(s => s.Id == id);
			if (shelter is not null)
			{
				_table.Remove(shelter);
				await SaveChangesDbAsync();
			}
		}

		public async Task UpdateAsync(Shelter entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}
	}
}
