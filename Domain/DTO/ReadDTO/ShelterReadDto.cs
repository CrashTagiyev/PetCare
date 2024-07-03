using Domain.Entities.Concretes;
using Domain.Identity;

namespace Domain.DTO.ReadDTO;

public class ShelterReadDto
{
    public int Id { get; set; }
    public string Company { get; set; }
    public string Location { get; set; }
    public ICollection<PetReadDto> Pets { get; set; }
}