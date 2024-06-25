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
	public class AcceptRequestReadRepository : GenericRepository<AcceptRequest>, IAcceptRequestReadRepository
	{
		public AcceptRequestReadRepository(PetCareDB context) : base(context)
		{
		}

		public Task<ICollection<AcceptRequest>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<AcceptRequest> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
