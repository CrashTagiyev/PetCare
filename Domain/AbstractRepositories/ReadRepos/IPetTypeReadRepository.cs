using Domain.AbstractRepositories.GenericRepos;
using Domain.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AbstractRepositories.ReadRepos
{
    public interface IPetTypeReadRepository:IGenericReadRepository<PetType>
	{
	}
}
