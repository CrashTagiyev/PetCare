using Domain.Identity;

namespace Domain.DTO.ReadDTO;

public class ReadDonationDto
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string User { get; set; }
    public string Company { get; set; }
}