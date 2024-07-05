using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.IdentityRepos
{
	internal class AppUserWriteRepository : GenericRepository<AppUser>, IAppUserWriteRepository
	{
		public AppUserWriteRepository(PetCareDB context) : base(context)
		{
		}

		public async Task CreateAsync(AppUser entity)
		{
			await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var user = await _table.FirstOrDefaultAsync(u => u.Id == id);

			if (user is not null)
			{
				_table.Remove(user);
				await SaveChangesDbAsync();
			}
		}
		public async Task UpdateAsync(AppUser entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}

	}
}
