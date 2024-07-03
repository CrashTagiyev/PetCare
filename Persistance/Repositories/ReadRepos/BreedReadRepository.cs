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
	public class BreedReadRepository : GenericRepository<Breed>, IBreedReadRepository
	{
		public BreedReadRepository(PetCareDB context) : base(context)
		{
		}

		public async Task<ICollection<Breed>> GetAllAsync()
		{
			return await _table.ToListAsync();
		}

		public async Task<Breed?> GetByIdAsync(int id)
		{
			return await _table.FirstOrDefaultAsync(b => b.Id == id);
		}
	}
}
