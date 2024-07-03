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
	public class LocationReadRepository : GenericRepository<Location>, ILocationReadRepository
	{
		public LocationReadRepository(PetCareDB context) : base(context)
		{
		}

		public Task<ICollection<Location>> GetAllAsync()
		{


		}

		public Task<Location> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
