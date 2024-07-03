using Domain.AbstractRepositories.GenericRepos;
using Domain.Entities.Concretes;

namespace Domain.AbstractRepositories.WriteRepos
{
	public interface IPetWriteRepository : IGenericWriteRepository<Pet>
	{
		Task AddPetsInRangeAsync(params Pet[] pets);
	}
}
