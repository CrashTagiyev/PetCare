using Domain.Entities.Concretes;

namespace Domain.DTO.ReadDTO;

public class PetReadDto
{
    public int Id { get; set; }
    public string? PetName { get; set; }
    public string? Description { get; set; }
    public string? Size { get; set; }
    public short Age { get; set; }
    public string? Gender { get; set; }
    public string[]? ImageUrls { get; set; }
    public bool IsAdopted { get; set; }
    public string Health { get; set; }
    public decimal Weight { get; set; }
    
    public string PetType { get; set; }
    public string  Shelter { get; set; }
    public Adoption?  Adoption { get; set; } // Emil ile muzakire ...
}