using Domain.DTOs.ReadDTO.IdentityDTOs;

namespace Application.ServiceAbstracts.UserServices
{
    public interface IVetService
    {
        //Vets functions
        Task<VetInfoDTO> GetVetInfoDTO(int id);
        Task<List<VetInfoDTO>> GetVetInfoDTOList();
        Task LikeVet(int id);
        Task DislikeVet(int id);

    }
}
