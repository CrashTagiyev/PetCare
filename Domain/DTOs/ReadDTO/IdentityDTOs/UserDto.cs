namespace Domain.DTOs.ReadDTO.IdentityDTOs;

public class UserDto
{
    public string? UserName { get; set; }
    public string? Firstname { get; set; }
	public string? Lastname { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? City { get; set; }
    public string? Address { get; set; }
    public string? ProfileImageUrl { get; set; }
}