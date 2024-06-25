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
	public class AdoptionReadRepository : GenericRepository<Adoption>, IAdoptionReadRepository
	{
		public AdoptionReadRepository(PetCareDB context) : base(context)
		{
		}

		public Task<ICollection<Adoption>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Adoption> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
