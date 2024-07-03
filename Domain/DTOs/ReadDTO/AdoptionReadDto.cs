namespace Domain.DTOs.ReadDTO;

public class AdoptionReadDto
{
    public int Id { get; set; }
    public PetReadDto Pet { get; set; }
    public string User { get; set; }
}