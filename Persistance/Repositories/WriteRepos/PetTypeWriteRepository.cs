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
    public class PetTypeWriteRepository : GenericRepository<PetType>, IPetTypeWriteRepository
	{
		public PetTypeWriteRepository(PetCareDB context) : base(context)
		{
		}

		public Task CreateAsync(PetType entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}



		public Task UpdateAsync(PetType entity)
		{
			throw new NotImplementedException();
		}
	}
}
