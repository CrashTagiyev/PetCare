using Domain.AbstractRepositories.IdentityRepos;
using Domain.Identity;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.IdentityRepos;

public class UserTokenReadRepository: GenericRepository<Token> , IUserTokenReadRepository
{
    public UserTokenReadRepository(PetCareDB context) : base(context)
    {
    }

    public Task<Token?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Token>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}