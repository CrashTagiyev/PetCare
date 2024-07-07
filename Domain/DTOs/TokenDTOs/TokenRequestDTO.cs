using System.Security.Claims;
using System.Text.Json;

namespace Domain.DTOs.TokenDTOs
{
	public class TokenRequestDTO
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public IList<string> Roles { get; set; }
		public List<Claim> Claims { get; set; }
	}
}
