using Domain.AbstractRepositories.ReadRepos;
using Domain.Entities.Concretes;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.ReadRepos;

public class ShelterReadRepository: GenericRepository<Shelter> , ISheltterReadRepository
{
    public ShelterReadRepository(PetCareDB context) : base(context)
    {
    }

    public Task<Shelter> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Shelter>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}