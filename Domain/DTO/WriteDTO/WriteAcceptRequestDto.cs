namespace Domain.DTO.WriteDTO;

public class WriteAcceptRequestDto
{
    public string? Description { get; set; }
    public int UserId { get; set; }
    public PetWriteDto Pet { get; set; }
}