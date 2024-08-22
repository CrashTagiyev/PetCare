using Application.ServiceAbstracts.UserServices;
using AutoMapper;
using Domain.AbstractRepositories.EntityRepos.ReadRepos;
using Domain.AbstractRepositories.EntityRepos.WriteRepos;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.ReadDTO.IdentityDTOs;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using System.Net;

namespace Infrastructure.InternalServices
{
	public class CompanyService : ICompanyService
	{
		private readonly IAppUserReadRepository _userReadRepository;
		private readonly IAppUserWriteRepository _userWriteRepository;
		private readonly IShelterWriteRepository _shelterWriteRepository;
		private readonly IShelterReadRepository _shelterReadRepository;
		private readonly UserManager<AppUser> _userManager;
		private readonly IMapper _mapper;
		public CompanyService(IAppUserReadRepository userReadRepository, IAppUserWriteRepository userWriteRepository, UserManager<AppUser> userManager, IMapper mapper, IShelterWriteRepository shelterWriteRepository, IShelterReadRepository shelterReadRepository)
		{
			_userReadRepository = userReadRepository;
			_userWriteRepository = userWriteRepository;
			_userManager = userManager;
			_mapper = mapper;
			_shelterWriteRepository = shelterWriteRepository;
			_shelterReadRepository = shelterReadRepository;
		}

		public async Task<HttpStatusCode> CreateShelter(ShelterWriteDto shelterWriteDto)
		{
			if (shelterWriteDto is null)
				return HttpStatusCode.BadRequest;

			var companies = await _userManager.GetUsersInRoleAsync("Company");

			var company = companies.FirstOrDefault(c => c.Id == shelterWriteDto.CompanyId);
			if (company is null)
				return HttpStatusCode.NotFound;

			var newShelter = _mapper.Map<Shelter>(shelterWriteDto);
			company.Shelters.Add(newShelter);
			await _userManager.UpdateAsync(company);
			return HttpStatusCode.OK;
		}

		public async Task<CompanyProfileReadDTO> GetCompanyProfileInfo(int id)
		{
			var companies = await _userManager.GetUsersInRoleAsync("Company");
			try
			{
				var searchedCompany = companies.Select(_mapper.Map<CompanyProfileReadDTO>).FirstOrDefault(c => c.Id == id);
				if (searchedCompany is not null)
					return searchedCompany;

				else throw new Exception("Company with given id did not found");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}

		}
	}
}
