using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
    public class PetTypeReadRepository : GenericRepository<PetType>, IPetTypeReadRepository
    {
        public PetTypeReadRepository(PetCareDB context) : base(context)
        {
        }

        public async Task<ICollection<PetType>> GetAllAsync()
        {
            return await _table.Include(pt=>pt.Breeds).Include(pt=>pt.Vets).ToListAsync();
        }

        public async Task<PetType?> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(pt => pt.Id == id);
        }
    }
}
