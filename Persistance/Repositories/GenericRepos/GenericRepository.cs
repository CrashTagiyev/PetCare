using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;


namespace Persistance.Repositories.GenericRepos
{
    public class GenericRepository<T> where T : Entity, new()
    {
        protected readonly PetCareDB _context;
        protected readonly DbSet<T> _table;
        public GenericRepository(PetCareDB context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
    }
}
