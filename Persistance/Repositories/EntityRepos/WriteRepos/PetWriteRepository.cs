using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;

namespace Persistance.Repositories.EntityRepos.WriteRepos
{
    public class PetWriteRepository : GenericRepository<Pet>, IPetWriteRepository
    {
        public PetWriteRepository(PetCareDB context)
            : base(context)
        {

        }

        public async Task AddPetsInRangeAsync(params Pet[] pets)
        {
            await _table.AddRangeAsync(pets);
			await SaveChangesDbAsync();
		}

        public async Task CreateAsync(Pet entity)
        {
            await _table.AddAsync(entity);
			await SaveChangesDbAsync();
		}

        public async Task DeleteAsync(int id)
        {
            var pet = await _context.Pets.FirstOrDefaultAsync(p => p.Id == id);
            if (pet != null)
            {
                _table.Remove(pet);
				await SaveChangesDbAsync();
			}
        }

        public async Task UpdateAsync(Pet entity)
        {
            _table.Update(entity);
			await SaveChangesDbAsync();
		}
    }
}
