using Application.ServiceAbstracts;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.DTOs.ReadDTO;
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
	}
}
