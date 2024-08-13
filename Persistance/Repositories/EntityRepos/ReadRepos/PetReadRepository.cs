using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
    public class PetReadRepository : GenericRepository<Pet>, IPetReadRepository
    {
        public PetReadRepository(PetCareDB context) : base(context)
        {
        }

        public async Task<ICollection<Pet>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<Pet?> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
