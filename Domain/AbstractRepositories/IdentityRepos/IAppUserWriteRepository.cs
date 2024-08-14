using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Identity;

namespace Domain.AbstractRepositories.IdentityRepos
{
	public interface IAppUserWriteRepository : IGenericWriteRepository<AppUser>
	{
		Task LikeVet(int id);
		Task DislikeVet(int id);
	}
}
