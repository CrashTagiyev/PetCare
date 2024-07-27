using Domain.Identity;

namespace Application.ServiceAbstracts
{
	public interface IEmailService
	{
		Task SendEmailAsync(string toEmail, string subject, string body, bool isBodyHTML);
		Task SendEmailConfirm(AppUser user);
		Task SendResetPassword(AppUser user,string token);
	}
}
