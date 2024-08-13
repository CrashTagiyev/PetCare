namespace Domain.DTOs.ReadDTO;

public class LocationReadDto
{
    public int Id { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Street { get; set; }

    public ShelterReadDto Shelter { get; set; }
}