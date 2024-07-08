using Domain.Identity;

namespace Application.AbstractServices
{
	public interface IEmailService
	{
		Task SendEmailAsync(string toEmail, string subject, string body, bool isBodyHTML);
		Task SendEmailConfirm(AppUser user);
		Task SendResetPassword(AppUser user,string token);
	}
}
