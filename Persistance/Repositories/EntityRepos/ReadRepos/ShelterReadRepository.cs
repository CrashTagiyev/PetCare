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
            return await _table.ToListAsync();
        }

        public async Task<Shelter?> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
