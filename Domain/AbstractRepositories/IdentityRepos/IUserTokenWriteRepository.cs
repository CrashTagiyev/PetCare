using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Identity;

namespace Domain.AbstractRepositories.IdentityRepos;

public interface IUserTokenWriteRepository: IGenericWriteRepository<Token>
{
    
}