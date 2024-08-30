using Application.ServiceAbstracts;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.DTOs.ReadDTO;
using Domain.Entities.Concretes;
using Domain.Models.EntityModels;

namespace Infrastructure.InternalServices
{
	public class PetService : IPetService
	{
		private readonly IPetTypeReadRepository _petTypeReadRepository;
		private readonly IPetTypeWriteRepository _petTypeWriteRepository;
		private readonly IBreedReadRepository _breedReadRepository;
		private readonly IBreedWriteRepository _breedWriteRepository;
		private readonly IPetReadRepository _petReadRepository;
		private readonly IPetWriteRepository _petWriteRepository;
		private readonly IMapper _mapper;
		public PetService(IPetTypeReadRepository petTypeReadRepository, IPetTypeWriteRepository petTypeWriteRepository, IBreedReadRepository breedReadRepository, IBreedWriteRepository breedWriteRepository, IPetReadRepository petReadRepository, IPetWriteRepository petWriteRepository, IMapper mapper)
		{
			_petTypeReadRepository = petTypeReadRepository;
			_petTypeWriteRepository = petTypeWriteRepository;
			_breedReadRepository = breedReadRepository;
			_breedWriteRepository = breedWriteRepository;
			_petReadRepository = petReadRepository;
			_petWriteRepository = petWriteRepository;
			_mapper = mapper;
		}

		public async Task<List<BreedReadDto>> GetBreedTypesByPetTypeAsync(int PetTypeId)
		{
			var petTypes = await _petTypeReadRepository.GetAllAsync();
			return petTypes.FirstOrDefault(pt => pt.Id == PetTypeId)!.Breeds!.Select(_mapper.Map<BreedReadDto>).ToList();
		}

		public async Task<List<PetReadDto>> GetFilteredPets(PetFilterModel filterModel)
		{
			var pets = await _petReadRepository.GetAllFilteredAsync(filterModel);
			return pets.Select(_mapper.Map<PetReadDto>).ToList();
		}

		public async Task<PetReadDto> GetPetByIdAsync(int PetId)
		{
			var pet = await _petReadRepository.GetByIdAsync(PetId);
			return _mapper.Map<PetReadDto>(pet);
		}

		public async Task<List<PetTypeReadDto>> GetPetTypesAsync()
		{
			var petTypes = await _petTypeReadRepository.GetAllAsync();
			return petTypes.Select(_mapper.Map<PetTypeReadDto>).ToList();
		}
	}
}
