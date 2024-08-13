using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.IdentityRepos
{
	internal class AppUserWriteRepository : GenericRepository<AppUser>, IAppUserWriteRepository
	{
		private readonly UserManager<AppUser> _userManager;
		public AppUserWriteRepository(PetCareDB context, UserManager<AppUser> userManager) : base(context)
		{
			_userManager = userManager;
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
