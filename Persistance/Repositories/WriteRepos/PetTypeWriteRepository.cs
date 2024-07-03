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
    public class PetTypeWriteRepository : GenericRepository<PetType>, IPetTypeWriteRepository
	{
		public PetTypeWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(PetType entity)
		{
			await _table.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var petType = await _table.FirstOrDefaultAsync(pt => pt.Id == id);
			if (petType is not null)
				_table.Remove(petType);
		}



		public  Task UpdateAsync(PetType entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
