namespace Domain.DTOs.WriteDTO;

public class AdoptionWriteDto
{
    public int PetId { get; set; }
    public int UserId { get; set; }
    public string About { get; set; }
	public int YearsOfPetExperience { get; set; }
}