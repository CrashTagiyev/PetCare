using Domain.AbstractRepositories.GenericRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;


namespace Persistance.Repositories.WriteRepos
{
	public class ShelterWriteRepository : GenericRepository<Shelter>, IGenericWriteRepository<Shelter>
	{
		public ShelterWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Shelter entity)
		{
			await _table.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var shelter = await _table.FirstOrDefaultAsync(s => s.Id == id);
			if (shelter is not null)
				_table.Remove(shelter);
		}

		public Task UpdateAsync(Shelter entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
