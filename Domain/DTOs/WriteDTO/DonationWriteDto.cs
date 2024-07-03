namespace Domain.DTOs.WriteDTO;

public class DonationWriteDto
{
    public decimal? Amount { get; set; }
    public string CompanyId { get; set; }
    public string UserId { get; set; }
}