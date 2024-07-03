using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AbstractRepositories.GenericRepos
{
    public interface IGenericReadRepository<T> where T : Entity, new()
    {
        Task<T?> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}
