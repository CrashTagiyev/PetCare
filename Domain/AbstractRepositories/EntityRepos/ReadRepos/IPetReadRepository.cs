using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Entities.Concretes;
using Domain.Models.EntityModels;

namespace Domain.AbstractRepositories.EntityRepos.ReadRepos
{
    public interface IPetReadRepository : IGenericReadRepository<Pet>
    {
        Task<List<Pet>> GetAllFilteredAsync(PetFilterModel filterModel);
    }
}
