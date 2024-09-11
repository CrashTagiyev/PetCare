using Microsoft.AspNetCore.Http;

namespace Domain.DTOs.AdminPanelDTOs.AppUserControlDTOs
{
    public class AppUserReadAdminDTO
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}
