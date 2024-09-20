using Domain.DTOs.ReadDTO.IdentityDTOs;
using Domain.Enums;

namespace Domain.DTOs.ReadDTO;

public class AdoptionReadDto
{
    public int Id { get; set; }
    public PetReadDto Pet { get; set; }
    public UserDto User { get; set; }
    public Acceptstatus isAccepted { get; set; }
    public string About { get; set; }
    public int YearsOfPetExperience { get; set; }
}