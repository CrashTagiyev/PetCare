using Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Domain.DTOs.WriteDTO;

public class PetWriteDto
{
    public string? PetName { get; set; }
    public string? Description { get; set; }
    public string? Size { get; set; }
    public short? Age { get; set; }
    public Gender? Gender { get; set; }
    public IFormFile[]? ImageUrls { get; set; }
    public string? Health { get; set; }
    public decimal? Weight { get; set; }
    
    public int? PetTypeId { get; set; }
    public int? BreedId { get; set; }
    public int ShelterId { get; set; }
}