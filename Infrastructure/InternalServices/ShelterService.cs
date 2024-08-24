using Application.ServiceAbstracts;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.InternalServices
{
	public class ShelterService : IShelterService
	{
		private readonly IShelterReadRepository _shelterReadRepository;
		private readonly IShelterWriteRepository _shelterWriteRepository;
		private readonly IMapper _mapper;
		public ShelterService(IShelterReadRepository shelterReadRepository, IShelterWriteRepository shelterWriteRepository, IMapper mapper)
		{
			_shelterReadRepository = shelterReadRepository;
			_shelterWriteRepository = shelterWriteRepository;
			_mapper = mapper;
		}

		public async Task<List<ShelterReadDto>> GetAllShelters()
		{
			try
			{
				var shelters = await _shelterReadRepository.GetAllAsync();
				return shelters.Select(_mapper.Map<ShelterReadDto>).ToList();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public Task<ShelterReadDto> GetShelterById()
		{
			throw new NotImplementedException();
		}

		public async Task<string> AddPetToShelter(int shelterId,PetWriteDto petWriteDto)
		{
			try
			{
				var shelter = await _shelterReadRepository.GetByIdAsync(shelterId);
				if (shelter is not null)
				{
					var pet = _mapper.Map<Pet>(petWriteDto);
					shelter.Pets.Add(pet);
					await _shelterWriteRepository.UpdateAsync(shelter);
					return "Pet is successfully added";
				}

				return "Shelter is not exist";

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
