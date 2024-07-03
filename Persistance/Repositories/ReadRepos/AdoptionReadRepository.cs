using Domain.AbstractRepositories.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
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

		public async Task<ICollection<Adoption>> GetAllAsync()
		{
			await _table.ToListAsync();

		}

		public Task<Adoption> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
