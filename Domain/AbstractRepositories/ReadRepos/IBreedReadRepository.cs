using Domain.AbstractRepositories.GenericRepos;
using Domain.Entities.Concretes;

namespace Domain.AbstractRepositories.ReadRepos
{
	public interface IBreedReadRepository : IGenericReadRepository<Breed>
	{
	}
}
