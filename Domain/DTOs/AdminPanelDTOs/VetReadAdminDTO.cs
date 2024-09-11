using Domain.DTOs.ReadDTO;

namespace Domain.DTOs.AdminPanelDTOs
{
    public class VetReadAdminDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        ////Vet
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string? About { get; set; }
        public List<PetTypeReadDto> PetTypes { get; set; }
    }
}
