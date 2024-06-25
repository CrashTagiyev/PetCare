using Domain.AbstractRepositories.GenericRepos;
using Domain.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AbstractRepositories.WriteRepos
{
    public interface IPetWriteRepository : IGenericWriteRepository<Pet>
    {
        Task AddPetsInRangeAsync(params Pet[] pets);
	}
}
