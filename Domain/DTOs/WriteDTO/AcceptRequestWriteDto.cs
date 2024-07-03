namespace Domain.DTOs.WriteDTO;

public class AcceptRequestWriteDto
{
    public string? Description { get; set; }
    public PetWriteDto Pet { get; set; }
    public string UserId { get; set; }
}