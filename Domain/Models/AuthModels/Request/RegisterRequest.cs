using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Domain.Models.AuthModels.Request;
public class RegisterRequest
{
    public string? Firstname { get; set; } = string.Empty;
    public string? Lastname { get; set; } = string.Empty;
    public string? UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime? DateOfBirth { get; set; }
    public string? City { get; set; } = string.Empty;
    public string? Address { get; set; } = string.Empty;
    public string? Password { get; set; } = string.Empty;
    public IFormFile? ProfileImage { get; set; }
}