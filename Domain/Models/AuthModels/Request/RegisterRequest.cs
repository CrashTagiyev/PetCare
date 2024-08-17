using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Domain.Models.AuthModels.Request;
public class RegisterRequest
{
    public string? Firstname { get; set; } 
    public string? Lastname { get; set; } 
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? City { get; set; } 
    public string? Address { get; set; } 
    public string? Password { get; set; } 
    public IFormFile? ProfileImage { get; set; }
}