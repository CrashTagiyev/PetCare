using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class BreedWriteRepository : GenericRepository<Breed>, IBreedWriteRepository
	{
		public BreedWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Breed entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var breed = await _table.FirstOrDefaultAsync(b => b.Id == id);
			if (breed is not null)
			{

				_table.Remove(breed);
				await SaveChangesDbAsync();
			}
		}


		public async Task UpdateAsync(Breed entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}
	}
}
