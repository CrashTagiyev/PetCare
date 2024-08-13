using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
    public class DonationReadRepository : GenericRepository<Donation>, IDonationReadRepository
    {
        public DonationReadRepository(PetCareDB context) : base(context)
        {
        }

        public async Task<ICollection<Donation>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<Donation?> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(d => d.Id == id);
        }
    }
}
