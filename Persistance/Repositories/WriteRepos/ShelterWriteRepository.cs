using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Concretes;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.WriteRepos;

public class ShelterWriteRepository: GenericRepository<Shelter> , IShelterWriteRepository
{
    public ShelterWriteRepository(PetCareDB context) : base(context)
    {
    }

    public Task CreateAsync(Shelter entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Shelter entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}