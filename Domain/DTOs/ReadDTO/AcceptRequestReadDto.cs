using Domain.Enums;
using Domain.Enums.EnumsExtensions;

namespace Domain.DTOs.ReadDTO;

public class  AcceptRequestReadDto
{
    public int Id { get; set; }
    public string? AcceptStatus { get; set; }
    public string? Description { get; set; }
    public PetReadDto Pet { get; set; }
    public string User { get; set; }
}