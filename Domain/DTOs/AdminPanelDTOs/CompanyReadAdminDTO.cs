using Domain.DTOs.ReadDTO;

namespace Domain.DTOs.AdminPanelDTOs
{
    public class CompanyReadAdminDTO
    {
        public int Id { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }   
        //Company
        public string? CompanyName { get; set; }
        public virtual ICollection<ShelterReadDto>? Shelters { get; set; }
        public string? PhoneNumber { get; set; }
        //Vet/Company
        public string? About { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }

    }
}
