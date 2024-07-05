using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Entities.Concretes;

namespace Domain.AbstractRepositories.EntityRepos.ReadRepos
{
    public interface IPetReadRepository : IGenericReadRepository<Pet>
    {
    }
}
