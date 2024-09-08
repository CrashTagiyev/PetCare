using Domain.DTOs.ReadDTO.IdentityDTOs;
using Domain.Entities.Concretes;

namespace Domain.DTOs.ReadDTO;

public class ShelterReadDto
{
    public int Id { get; set; }
    public string? ShelterName { get; set; }
	public string? AboutShelter { get; set; }
	public string? AdoptionPolicy { get; set; }
	public string? City { get; set; }
	public string? Address { get; set; }
	public string? PhoneNumber { get; set; }
	public string? EmailAddress { get; set; }
	public string? ShelterImageUrl { get; set; }
	public CompanyProfileReadDTO Company { get; set; }
}