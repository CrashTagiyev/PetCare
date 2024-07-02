using Domain.AbstractRepositories.WriteRepos;
using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;
using Persistance.Repositories.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.WriteRepos
{
    public class PetWriteRepository : GenericRepository<Pet>, IPetWriteRepository
    {
        public PetWriteRepository(PetCareDB context)
            : base(context)
        {

        }

        public Task AddPetsInRangeAsync(params Pet[] pets)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Pet entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
           var pet= await _context.Pets.FirstOrDefaultAsync(p=>p.Id==id);
            if (pet!=null)
            {
               
            }
        }

        public Task UpdateAsync(Pet entity)
        {
            throw new NotImplementedException();
        }
    }
}
