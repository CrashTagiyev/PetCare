using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AbstractRepositories.IdentityRepos
{
	public interface IAppUserReadRepository:IGenericReadRepository<AppUser>
	{

	}
}
