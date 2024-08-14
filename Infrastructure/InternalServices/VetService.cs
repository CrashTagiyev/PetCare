using Application.ServiceAbstracts.UserServices;
using AutoMapper;
using Domain.AbstractRepositories.IdentityRepos;
using Domain.DTOs.ReadDTO.IdentityDTOs;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.InternalServices
{
	public class VetService : IVetService
	{

		private readonly IAppUserReadRepository _appUserReadRepository;
		private readonly IAppUserWriteRepository _appUserWriteRepository;
		private readonly UserManager<AppUser> _userManager;
		private readonly IMapper _mapper;

		public VetService(IAppUserReadRepository appUserReadRepository, IAppUserWriteRepository appUserWriteRepository, UserManager<AppUser> userManager, IMapper mapper)
		{
			_appUserReadRepository = appUserReadRepository;
			_appUserWriteRepository = appUserWriteRepository;
			_userManager = userManager;
			_mapper = mapper;
		}

		public async Task DislikeVet(int id)
		{
			try
			{
				await _appUserWriteRepository.DislikeVet(id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public async Task LikeVet(int id)
		{
			try
			{
				await _appUserWriteRepository.LikeVet(id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public async Task<VetInfoDTO> GetVetInfoDTO(int id)
		{
			try
			{
				var vet = await _appUserReadRepository.GetByIdAsync(id);
				var vetInfoDTO = _mapper.Map<VetInfoDTO>(vet);
				return vetInfoDTO;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public async Task<List<VetInfoDTO>> GetVetInfoDTOList()
		{
			try
			{
				var vetsList = await _userManager.GetUsersInRoleAsync("Vet");
				var vetInfoDTOList = vetsList.Select(_mapper.Map<VetInfoDTO>).ToList();
				return vetInfoDTOList;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
