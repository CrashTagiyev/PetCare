namespace Domain.DTOs.ReadDTO;

public class ShelterReadDto
{
    public int Id { get; set; }
    public string? ShelterName { get; set; }
	public string? AboutShelter { get; set; }
	public string? AdoptionPolicy { get; set; }
	public string? City { get; set; }
	public string? Address { get; set; }
	public string? ShelterImageUrl { get; set; }
}