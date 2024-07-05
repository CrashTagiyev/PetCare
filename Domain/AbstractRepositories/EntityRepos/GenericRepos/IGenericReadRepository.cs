using Domain.Entities.Abstracts;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace Domain.AbstractRepositories.EntityRepos.GenericRepos
{
    public interface IGenericReadRepository<T> where T : IBaseEntity, new()
    {
        Task<T?> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}
