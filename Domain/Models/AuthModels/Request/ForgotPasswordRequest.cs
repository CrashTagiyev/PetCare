
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.AuthModels.Request
{
	public class ForgotPasswordRequest
	{
        public string Email { get; set; }=string.Empty;
    }
}
