using Domain.Entities.Concretes;

namespace Domain.DTOs.ReadDTO.IdentityDTOs
{
	public class VetInfoDTO
	{
		//Base entity props
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string? ProfileImageUrl { get; set; }
		
		////Vet
		public int Likes { get; set; } 
		public int Dislikes { get; set; } 
		public string? About { get; set; }

	}
}
