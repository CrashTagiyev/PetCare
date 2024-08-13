using Domain.Entities.Abstracts;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;


namespace Persistance.Repositories.GenericRepos
{
    public class GenericRepository<T> where T :class, IBaseEntity , new()
    {
        protected readonly PetCareDB _context;
        protected readonly DbSet<T> _table;
        public GenericRepository(PetCareDB context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        protected async Task SaveChangesDbAsync()
        {
            await _context.SaveChangesAsync();
        }
        protected void SaveChangesDb()
        {
            _context.SaveChanges();
        }
    }
}


