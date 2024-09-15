using Microsoft.AspNetCore.Http;

namespace Domain.Models.AuthModels.Request
{
	public class RegisterVetRequest
	{
		public string? UserName { get; set; }
		public string? Password { get; set; }
		public string? Firstname { get; set; }
		public string? Lastname { get; set; }

		public string? Email { get; set; }
		public string? About { get; set; }
		public string? City { get; set; }
		public string? Address { get; set; }
		public string? PhoneNumber { get; set; }
		public string[]? ProficientPetTypesIds { get; set; }
		public IFormFile? ProfileImage { get; set; }
		public DateTime? DateOfBirth { get; set; }

	}
}
