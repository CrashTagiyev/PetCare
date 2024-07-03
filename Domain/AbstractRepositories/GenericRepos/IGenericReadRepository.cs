using Domain.Entities.Abstracts;

namespace Domain.AbstractRepositories.GenericRepos
{
	public interface IGenericReadRepository<T> where T : Entity, new()
	{
		Task<T?> GetByIdAsync(int id);
		Task<ICollection<T>> GetAllAsync();
	}
}
