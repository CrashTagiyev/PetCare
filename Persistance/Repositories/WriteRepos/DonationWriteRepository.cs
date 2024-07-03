using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.WriteRepos
{
	public class DonationWriteRepository : GenericRepository<Donation>, IDonationWriteRepository
	{
		public DonationWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Donation entity)
		{
			await _table.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var donation = await _table.FirstOrDefaultAsync(d => d.Id == id);
			if (donation is not null)
				_table.Remove(donation);
		}



		public Task UpdateAsync(Donation entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
