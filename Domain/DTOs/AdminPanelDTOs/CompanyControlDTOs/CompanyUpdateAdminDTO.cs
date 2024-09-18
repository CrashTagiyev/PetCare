using Microsoft.AspNetCore.Http;

namespace Domain.DTOs.AdminPanelDTOs.CompanyControlDTOs
{
	public class CompanyUpdateAdminDTO
	{
		public int Id { get; set; }	
		public string? UserName { get; set; }
		public string? CompanyName { get; set; }
		public string? Email { get; set; }
		public string? About { get; set; }
		public IFormFile? ProfileImage { get; set; }
	}
}
