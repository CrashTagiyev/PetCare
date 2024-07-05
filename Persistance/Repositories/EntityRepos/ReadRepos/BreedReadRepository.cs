using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
    public class BreedReadRepository : GenericRepository<Breed>, IBreedReadRepository
    {
        public BreedReadRepository(PetCareDB context) : base(context)
        {
        }

        public async Task<ICollection<Breed>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<Breed?> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
