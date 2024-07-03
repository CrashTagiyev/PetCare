namespace Domain.DTOs.ReadDTO;

public class PetTypeReadDto
{
    public int Id { get; set; }
    public string? TypeName { get; set; }
    public ICollection<BreedReadDto>? Breeds { get; set; }
    public ICollection<PetReadDto>? Pets { get; set; }
}