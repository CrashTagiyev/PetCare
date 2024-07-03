using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.WriteRepos
{
	public class LocationWriteRepository : GenericRepository<Location>, ILocationWriteRepository
	{
		public LocationWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Location entity)
		{
			await _table.AddAsync(entity);

		}

		public async Task DeleteAsync(int id)
		{
			var location = await _table.FirstOrDefaultAsync(l => l.Id == id);
			if (location is not null)
				_table.Remove(location);

		}


		public Task UpdateAsync(Location entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
