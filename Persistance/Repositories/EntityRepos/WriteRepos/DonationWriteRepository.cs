using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class DonationWriteRepository : GenericRepository<Donation>, IDonationWriteRepository
	{
		public DonationWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Donation entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var donation = await _table.FirstOrDefaultAsync(d => d.Id == id);
			if (donation is not null)
			{
				_table.Remove(donation);
				await SaveChangesDbAsync();
			}
		}



		public async Task UpdateAsync(Donation entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}
	}
}
