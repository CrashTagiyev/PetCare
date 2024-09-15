using Domain.DTOs.ReadDTO.IdentityDTOs;

namespace Domain.DTOs.ReadDTO;

public class AdoptionReadDto
{
    public int Id { get; set; }
    public PetReadDto Pet { get; set; }
    public UserDto User { get; set; }
    public bool isAccepted { get; set; }
    public string About { get; set; }
    public int YearsOfPetExperience { get; set; }
}