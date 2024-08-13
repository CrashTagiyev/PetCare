using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.ReadRepos
{
    public class AcceptRequestReadRepository : GenericRepository<AcceptRequest>, IAcceptRequestReadRepository
    {
        public AcceptRequestReadRepository(PetCareDB context) : base(context)
        {
        }

        public async Task<ICollection<AcceptRequest>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<AcceptRequest?> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(ar => ar.Id == id);
        }
    }
}
