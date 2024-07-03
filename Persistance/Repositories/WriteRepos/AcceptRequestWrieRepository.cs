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
	public class AcceptRequestWrieRepository : GenericRepository<AcceptRequest>, IAcceptRequestWriteRepository
	{
		public AcceptRequestWrieRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(AcceptRequest entity)
		{
			await _table.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var ar = await _table.FirstOrDefaultAsync(ar => ar.Id == id);
			if (ar is not null)
				_table.Remove(ar);
		}



		public Task UpdateAsync(AcceptRequest entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
