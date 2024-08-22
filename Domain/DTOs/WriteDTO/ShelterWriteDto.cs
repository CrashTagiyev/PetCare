namespace Domain.DTOs.WriteDTO;

public class ShelterWriteDto
{
    public int CompanyId { get; set; }
	public string? AboutShelter { get; set; }
	public string? AdoptionPolicy { get; set; }
	public string? City { get; set; }
	public string? Street { get; set; }
}