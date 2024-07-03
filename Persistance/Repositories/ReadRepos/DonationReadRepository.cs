using Domain.AbstractRepositories.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.ReadRepos
{
	public class DonationReadRepository : GenericRepository<Donation>, IDonationReadRepository
	{
		public DonationReadRepository(PetCareDB context) : base(context)
		{
		}

		public async Task<ICollection<Donation>> GetAllAsync()
		{
			await _table.ToListAsync();
		}

		public Task<Donation> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
