using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.DTOs.ReadDTO;
using Domain.Entities.Concretes;
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
		Task<ICollection<Shelter>> GetCompanySheltersByIdAsync(int companyId);
		public Task<ICollection<Adoption>> GetAdoptionsForCompanyAsync(int companyId);

	}
}
