using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Identity;

namespace Domain.AbstractRepositories.IdentityRepos
{
	public interface IAppUserReadRepository : IGenericReadRepository<AppUser>
	{
		Task<AppUser?> FinByRefreshToken(string refreshToken);
		Task<bool> IsUserNameExistAsync(string username);
		Task<bool> IsEmailExistAsync(string email);
		Task<bool> IsEmailConfirmedAsync(string email);
		Task<ICollection<AppUser>> GetCompanies();
	}
}
