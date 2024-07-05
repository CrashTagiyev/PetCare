using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class AcceptRequestWrieRepository : GenericRepository<AcceptRequest>, IAcceptRequestWriteRepository
	{
		public AcceptRequestWrieRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(AcceptRequest entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var ar = await _table.FirstOrDefaultAsync(ar => ar.Id == id);
			if (ar is not null)
			{
				_table.Remove(ar);
				await SaveChangesDbAsync();
			}
		}



		public async Task UpdateAsync(AcceptRequest entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}
	}
}
