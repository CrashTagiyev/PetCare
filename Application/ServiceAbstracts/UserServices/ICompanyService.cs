using Domain.DTOs.ReadDTO;
using Domain.DTOs.ReadDTO.IdentityDTOs;
using Domain.DTOs.WriteDTO;
using System.Net;

namespace Application.ServiceAbstracts.UserServices
{
	public interface ICompanyService
	{
		Task<CompanyProfileReadDTO> GetCompanyProfileInfo(int id);
		Task<HttpStatusCode> CreateShelter(ShelterWriteDto shelterWriteDto);
		Task<List<ShelterReadDto>> GetCompanySheltersById(int companyId);
		Task<ICollection<AdoptionReadDto>> GetAdoptionsForCompanyAsync(int companyId);
	}
}
