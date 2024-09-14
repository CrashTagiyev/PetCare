using Microsoft.AspNetCore.Http;

namespace Domain.DTOs.ReadDTO.AdminPanelDTOs.AppUserControlDTOs
{
	public class AppUserUpdateAdminDTO
	{
		public int Id { get; set; }
		public string? Firstname { get; set; }
		public string? Lastname { get; set; }
		public string? UserName { get; set; }
		public string? Email { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public string? City { get; set; }
		public string? Address { get; set; }
		public IFormFile? ProfileImage { get; set; }
		public string? PhoneNumber { get; set; }
	}
}
