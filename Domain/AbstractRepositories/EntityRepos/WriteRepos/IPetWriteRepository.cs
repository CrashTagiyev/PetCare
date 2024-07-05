using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Entities.Concretes;

namespace Domain.AbstractRepositories.EntityRepos.WriteRepos
{
    public interface IPetWriteRepository : IGenericWriteRepository<Pet>
    {
        Task AddPetsInRangeAsync(params Pet[] pets);
    }
}
