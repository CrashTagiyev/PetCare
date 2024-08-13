using Domain.Entities.Abstracts;

namespace Domain.AbstractRepositories.EntityRepos.GenericRepos
{
    public interface IGenericWriteRepository<T> where T : IBaseEntity, new()
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
