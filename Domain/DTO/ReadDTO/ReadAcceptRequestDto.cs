namespace Domain.DTO.ReadDTO;

public class ReadAcceptRequestDto
{
    public int Id { get; set; }
    public string? IsAccepted { get; set; }
    public string? Description { get; set; }
    public string Pet { get; set; }
    public string User { get; set; }
}