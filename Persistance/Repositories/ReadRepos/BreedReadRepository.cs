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
	public class BreedReadRepository : GenericRepository<Breed>, IBreedReadRepository
	{
		public BreedReadRepository(PetCareDB context) : base(context)
		{
		}

		public Task<ICollection<Breed>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Breed> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
