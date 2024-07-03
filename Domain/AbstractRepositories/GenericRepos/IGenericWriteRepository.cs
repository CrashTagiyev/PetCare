using Domain.Entities.Abstracts;

namespace Domain.AbstractRepositories.GenericRepos
{
	public interface IGenericWriteRepository<T> where T : Entity, new()
	{
		Task CreateAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(int id);
	}
}
