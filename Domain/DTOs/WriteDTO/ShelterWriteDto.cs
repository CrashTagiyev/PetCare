using Microsoft.AspNetCore.Http;

namespace Domain.DTOs.WriteDTO;

public class ShelterWriteDto
{
	public string? ShelterName { get; set; }
    public int CompanyId { get; set; }
	public string? AboutShelter { get; set; }
	public string? AdoptionPolicy { get; set; }
	public string? City { get; set; }
	public string? Address { get; set; }
	public string? PhoneNumber { get; set; }
	public string? EmailAddress { get; set; }
	public IFormFile? ShelterImage { get; set; }
}