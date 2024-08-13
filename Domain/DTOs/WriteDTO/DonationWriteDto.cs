namespace Domain.DTOs.WriteDTO;

public class DonationWriteDto
{
    public decimal? Amount { get; set; }
    public int CompanyId { get; set; }
    public int UserId { get; set; }
}