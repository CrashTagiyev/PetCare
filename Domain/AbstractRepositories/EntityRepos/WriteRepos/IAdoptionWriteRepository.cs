using System.Net;
using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace Domain.AbstractRepositories.EntityRepos.WriteRepos
{
    public interface IAdoptionWriteRepository : IGenericWriteRepository<Adoption>
    {
        public Task<Adoption> HandleAdoptRequest(int adoptionId, bool response);
    }
}
