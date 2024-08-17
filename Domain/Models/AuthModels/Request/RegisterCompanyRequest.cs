using Microsoft.AspNetCore.Http;

namespace Domain.Models.AuthModels.Request
{
	public class RegisterCompanyRequest
	{
        public string? UserName { get; set; }
        public string? CompanyName { get; set; }
		public string? Password { get; set; }
        public string? Email { get; set; }
		public string? About { get; set; }
		public IFormFile? ProfileImage { get; set; }
    }
}
