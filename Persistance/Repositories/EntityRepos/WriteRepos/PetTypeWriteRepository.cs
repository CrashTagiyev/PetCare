using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class PetTypeWriteRepository : GenericRepository<PetType>, IPetTypeWriteRepository
	{
		public PetTypeWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(PetType entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var petType = await _table.FirstOrDefaultAsync(pt => pt.Id == id);
			if (petType is not null)
			{
				_table.Remove(petType);
				await SaveChangesDbAsync();
			}
		}



		public async Task UpdateAsync(PetType entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}
	}
}
