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
    public class AdoptionWriteRepository : GenericRepository<Adoption>, IAdoptionWriteRepository
	{
		public AdoptionWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Adoption entity)
		{
			await _table.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var adoption=await _table.FirstOrDefaultAsync(a => a.Id==id);
			if (adoption is not null)
				_table.Remove(adoption);
		}



		public async Task UpdateAsync(Adoption entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
