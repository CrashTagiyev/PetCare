using System.Net;
using Domain.DTOs.WriteDTO;

namespace Application.ServiceAbstracts;

public interface IAdoptService
{
    Task<HttpStatusCode> CreateAdoptionAsync(AdoptionWriteDto adoptionWriteDto);
}