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
    public class BreedWriteRepository : GenericRepository<Breed>, IBreedWriteRepository
	{
		public BreedWriteRepository(PetCareDB context) : base(context)
		{
		}

		public Task CreateAsync(Breed entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}


		public Task UpdateAsync(Breed entity)
		{
			throw new NotImplementedException();
		}
	}
}
