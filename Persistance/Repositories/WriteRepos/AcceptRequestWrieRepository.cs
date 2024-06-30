using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Concretes;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.WriteRepos
{
    public class AcceptRequestWrieRepository : GenericRepository<AcceptRequest>, IAcceptRequestWriteRepository
	{
		public AcceptRequestWrieRepository(PetCareDB context) : base(context)
		{
		}

		public Task CreateAsync(AcceptRequest entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

	

		public Task UpdateAsync(AcceptRequest entity)
		{
			throw new NotImplementedException();
		}
	}
}
