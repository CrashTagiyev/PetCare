using Application.ServiceAbstracts;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.DTOs.ReadDTO;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

		public async Task<HttpStatusCode> AddPetToShelter(PetWriteDto petWriteDto)
		{
			try
			{
				var shelter = await _shelterReadRepository.GetByIdAsync(petWriteDto.ShelterId);
				if (shelter is not null)
				{
					var pet = _mapper.Map<Pet>(petWriteDto);
					shelter.Pets.Add(pet);
					await _shelterWriteRepository.UpdateAsync(shelter);
					return HttpStatusCode.OK;
				}

				return HttpStatusCode.NotFound;

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
