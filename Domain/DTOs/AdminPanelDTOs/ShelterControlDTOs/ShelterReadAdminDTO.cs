using Domain.DTOs.AdminPanelDTOs.PetControlDTOs;

namespace Domain.DTOs.AdminPanelDTOs.ShelterControlDTOs
{
	public class ShelterReadAdminDTO
	{
		public int Id { get; set;}
		public int CompanyId { get; set; }
		public string? ShelterName { get; set; }
		public string? AboutShelter { get; set; }
		public string? AdoptionPolicy { get; set; }
		public string? City { get; set; }
		public string? Address { get; set; }
		public string? ShelterImageUrl { get; set; }
		public string? PhoneNumber { get; set; }
		public string? EmailAddress { get; set; }
		public DateTime CreatedTime { get; set; }

		//Navigation properties
		public CompanyReadAdminDTO Company { get; set; }
		public ICollection<PetReadAdminDTO> Pets { get; set; }

	}
}
