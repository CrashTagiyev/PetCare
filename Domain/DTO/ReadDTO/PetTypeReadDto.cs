using Domain.Entities.Concretes;

namespace Domain.DTO.ReadDTO;

public class PetTypeReadDto
{
    public int Id { get; set; }
    public string? TypeName { get; set; }
    public ICollection<Breed>? Breeds { get; set; }
    public ICollection<PetReadDto>? Pets { get; set; } // Emil ile muzakire ...
}