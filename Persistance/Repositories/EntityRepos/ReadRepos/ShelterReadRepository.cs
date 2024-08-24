using Domain.AbstractRepositories.EntityRepos.GenericRepos;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
    public class ShelterReadRepository : GenericRepository<Shelter>, IShelterReadRepository
    {
        public ShelterReadRepository(PetCareDB context) : base(context)
        {
        }

        public async Task<ICollection<Shelter>> GetAllAsync()
        {
            return await _table.Include(s => s.Company).Include(s => s.Pets).ToListAsync();
        }

        public async Task<Shelter?> GetByIdAsync(int id)
        {
            return await _table.Include(s=>s.Company).Include(s => s.Pets).FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
