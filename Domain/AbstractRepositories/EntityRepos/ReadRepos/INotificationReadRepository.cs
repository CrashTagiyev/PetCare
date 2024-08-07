using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Entities.Concretes;

namespace Domain.AbstractRepositories.EntityRepos.ReadRepos
{
	public interface INotificationReadRepository : IGenericReadRepository<Notification>
	{
		Task<IEnumerable<Notification>> GetNotificationsByUsername(string username);
	}
}
