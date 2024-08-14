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

		public async Task DislikeVet(int id)
		{
			var vet = await _table.FirstOrDefaultAsync(u => u.Id == id);
			
			if (vet is null)
				throw new Exception("Vet did not found\nFunction name:DislikeVet");

			++vet.Dislikes;
			await SaveChangesDbAsync();

		}

		public async Task LikeVet(int id)
		{
			var vet = await _table.FirstOrDefaultAsync(u => u.Id == id);

			if (vet is null)
				throw new Exception("Vet did not found\nFunction name:LikeVet");

			++vet.Likes;
			await SaveChangesDbAsync();

		}

		public async Task UpdateAsync(AppUser entity)
		{
			_table.Update(entity);
			await SaveChangesDbAsync();
		}

	}
}
