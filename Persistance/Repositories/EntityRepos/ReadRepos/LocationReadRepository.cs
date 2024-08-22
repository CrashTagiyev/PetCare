//using Domain.AbstractRepositories.EntityRepos.ReadRepos;
//using Domain.Entities.Concretes;
//using Microsoft.EntityFrameworkCore;
//using Persistance.Database;
//using Persistance.Repositories.GenericRepos;

//namespace Persistance.Repositories.EntityRepos.ReadRepos
//{
//    public class LocationReadRepository : GenericRepository<Location>, ILocationReadRepository
//    {
//        public LocationReadRepository(PetCareDB context) : base(context)
//        {
//        }

//        public async Task<ICollection<Location>> GetAllAsync()
//        {
//            return await _table.ToListAsync();
//        }

//        public async Task<Location?> GetByIdAsync(int id)
//        {
//            return await _table.FirstOrDefaultAsync(l => l.Id == id);
//        }
//    }
//}
