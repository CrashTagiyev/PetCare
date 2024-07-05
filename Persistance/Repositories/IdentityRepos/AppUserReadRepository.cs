using Domain.AbstractRepositories.IdentityRepos;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.IdentityRepos
{
	public class AppUserReadRepository : GenericRepository<AppUser>, IAppUserReadRepository
	{
		public AppUserReadRepository(PetCareDB context) : base(context)
		{
		}

		public async Task<ICollection<AppUser>> GetAllAsync()
		{
			return await _table.ToListAsync();
		}

		public async Task<AppUser?> GetByIdAsync(int id)
		{
			return await _table.FirstOrDefaultAsync(u => u.Id == id);
		}

	}
}
