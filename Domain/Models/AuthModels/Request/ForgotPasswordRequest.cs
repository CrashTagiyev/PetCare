
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.AuthModels.Request
{
	public class ForgotPasswordRequest
	{
		[EmailAddress]
        public string Email { get; set; }=string.Empty;
    }
}
