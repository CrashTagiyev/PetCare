using Domain.Entities.Concretes;

namespace Domain.DTOs.ReadDTO;

public class AdoptionReadDto
{
    public int Id { get; set; }
    public PetReadDto Pet { get; set; }
    public bool isAccepted { get; set; }
}