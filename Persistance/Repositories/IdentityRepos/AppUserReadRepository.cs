using Domain.AbstractRepositories.IdentityRepos;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.IdentityRepos
{
	public class AppUserReadRepository : GenericRepository<AppUser>, IAppUserReadRepository
	{
		private readonly UserManager<AppUser> _userManager;
		public AppUserReadRepository(PetCareDB context, UserManager<AppUser> userManager) : base(context)
		{
			_userManager = userManager;
		}



		public async Task<AppUser?> FinByRefreshToken(string refreshToken)
		{
			return await _table.FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);
		}

		public async Task<ICollection<AppUser>> GetAllAsync()
		{
			return await _table.ToListAsync();
		}

		public async Task<AppUser?> GetByIdAsync(int id)
		{
			var user = await _table.FirstOrDefaultAsync(u => u.Id == id);
			return user ?? throw new Exception("User did not found\nFunction name:GetByIdAsync");
		}

		public async Task<bool> IsEmailConfirmedAsync(string email)
		{
			var user = await _table.FirstOrDefaultAsync(u => u.NormalizedEmail == email.ToUpper());
			if (user != null)
				return user.EmailConfirmed;
			return false;
		}

		public async Task<bool> IsEmailExistAsync(string email)
		{
			return await _table.AnyAsync(u => u.NormalizedEmail == email.ToUpper());
		}

		public async Task<bool> IsUserNameExistAsync(string username)
		{
			return await _table.AnyAsync(u => u.NormalizedUserName == username.ToUpper());
		}
	}
}
