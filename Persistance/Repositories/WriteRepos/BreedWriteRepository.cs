using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
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

		public async Task CreateAsync(Breed entity)
		{
			await _table.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var breed = await _table.FirstOrDefaultAsync(b => b.Id == id);
			if (breed is not null)
				_table.Remove(breed);

		}


		public Task UpdateAsync(Breed entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
