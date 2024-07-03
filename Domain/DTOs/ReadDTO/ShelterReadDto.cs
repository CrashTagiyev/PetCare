namespace Domain.DTOs.ReadDTO;

public class ShelterReadDto
{
    public int Id { get; set; }
    public LocationReadDto Location { get; set; }
    public string Company { get; set; }
    public ICollection<PetReadDto> Pets { get; set; }
}