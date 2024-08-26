using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.Entities.Concretes;
using Domain.Enums;
using Domain.Models.EntityModels;
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

		public async Task<List<Pet>> GetAllFilteredAsync(PetFilterModel filterModel)
		{
			var pets = _table.AsQueryable();
			if (filterModel is not null && filterModel.IsAll is false)
			{
				if (filterModel.PetTypeId is not null && filterModel.PetTypeId > 0)
					pets = pets.Where(p => p.PetTypeId == filterModel.PetTypeId);

				if (filterModel.BreedId is not null && filterModel.BreedId > 0)
					pets = pets.Where(p => p.BreedId == filterModel.BreedId);

				if (filterModel.Gender is not null && (filterModel.Gender == Gender.Male || filterModel.Gender == Gender.Female))
					pets = pets.Where(p => p.Gender == filterModel.Gender);

				if (filterModel.MaxAge is not null && filterModel.MaxAge > 0)
					pets = pets.Where(p => p.Age <= filterModel.MaxAge);

				if (filterModel.MinAge is not null && filterModel.MinAge > 0)
					pets = pets.Where(p => p.Age >= filterModel.MinAge);

				if (filterModel.MaxWeight is not null && filterModel.MaxWeight > 0)
					pets = pets.Where(p => p.Weight <= filterModel.MaxWeight);

				if (filterModel.MinWeight is not null && filterModel.MinWeight > 0)
					pets = pets.Where(p => p.Weight >= filterModel.MinWeight);

				if (!string.IsNullOrEmpty(filterModel.Size))
					pets = pets.Where(p => p.Size!.Contains(filterModel.Size!));

				if (!string.IsNullOrEmpty(filterModel.PetName))
					pets = pets.Where(p => p.PetName!.Contains(filterModel.PetName!));
			}
			return await pets.ToListAsync();
		}

		public async Task<Pet?> GetByIdAsync(int id)
		{
			return await _table.FirstOrDefaultAsync(p => p.Id == id);
		}
	}
}
