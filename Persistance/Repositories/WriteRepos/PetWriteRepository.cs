using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.WriteRepos
{
	public class PetWriteRepository : GenericRepository<Pet>, IPetWriteRepository
	{
		public PetWriteRepository(PetCareDB context)
			: base(context)
		{

		}

		public async Task AddPetsInRangeAsync(params Pet[] pets)
		{
			await _table.AddRangeAsync(pets);
		}

		public async Task CreateAsync(Pet entity)
		{
			await _table.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var pet = await _context.Pets.FirstOrDefaultAsync(p => p.Id == id);
			if (pet != null)
			{
				_table.Remove(pet);
			}
		}

		public Task UpdateAsync(Pet entity)
		{
			_table.Update(entity);
			return Task.CompletedTask;
		}
	}
}
