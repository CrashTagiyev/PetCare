using Domain.AbstractRepositories.IdentityRepos;
using Domain.Identity;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.IdentityRepos;

public class UserTokenWriteRepository: GenericRepository<Token>,IUserTokenWriteRepository
{
    public UserTokenWriteRepository(PetCareDB context) : base(context)
    {
    }

    public Task CreateAsync(Token entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Token entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}