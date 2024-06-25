using Domain.AbstractRepositories.ReadRepos;
using Domain.Entities.Concretes;
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

		public Task<ICollection<Donation>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Donation> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
