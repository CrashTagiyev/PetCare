using System.Net;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Domain.Enums;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
	public class AdoptionWriteRepository : GenericRepository<Adoption>, IAdoptionWriteRepository
	{
		public AdoptionWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(Adoption entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var adoption = await _table.FirstOrDefaultAsync(a => a.Id == id);
			if (adoption is not null)
			{
				_table.Remove(adoption);
				await SaveChangesDbAsync();
			}
		}

		public async Task<Adoption> HandleAdoptRequest(int adoptionId, bool response)
		{
			var adoption = await _table.FirstOrDefaultAsync(a => a.Id == adoptionId);

			if (adoption is not null)
			{
				adoption.isAccepted = response ? Acceptstatus.Accepted : Acceptstatus.Denied;
				await UpdateAsync(adoption);
			}

			return adoption;
		}


		public async Task UpdateAsync(Adoption entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}


	}
}
