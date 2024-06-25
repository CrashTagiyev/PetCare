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
	public class PetReadRepository : GenericRepository<Pet>, IPetReadRepository
	{
		public PetReadRepository(PetCareDB context) : base(context)
		{
		}

		public Task<ICollection<Pet>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Pet> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
