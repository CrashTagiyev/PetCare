namespace Domain.DTOs.ReadDTO;

public class AcceptRequestReadDto
{
    public int Id { get; set; }
    public string? IsAccepted { get; set; }
    public string? Description { get; set; }
    public PetReadDto Pet { get; set; }
    public string User { get; set; }
}