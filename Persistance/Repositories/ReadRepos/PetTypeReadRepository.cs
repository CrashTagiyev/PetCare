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
	public class PetTypeReadRepository : GenericRepository<PetType>, IPetTypeReadRepository
	{
		public PetTypeReadRepository(PetCareDB context) : base(context)
		{
		}

		public Task<ICollection<PetType>> GetAllAsync()
		{
			throw new NotImplementedException();
		}-+

		public Task<PetType> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
