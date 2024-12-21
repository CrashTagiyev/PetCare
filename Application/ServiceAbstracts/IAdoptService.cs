using System.Net;
using Domain.DTOs.WriteDTO;
using Domain.Entities.Concretes;

namespace Application.ServiceAbstracts;

public interface IAdoptService
{
    Task<HttpStatusCode> CreateAdoptionAsync(AdoptionWriteDto adoptionWriteDto);
    Task<Adoption> HandleAdoptRequest(int adoptionId, bool response);
}