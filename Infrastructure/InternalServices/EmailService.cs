using Application.ServiceAbstracts;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace Infrastructure.ExternalServices;

public class EmailService : IEmailService
{
	private readonly IConfiguration _config;
	private readonly UserManager<AppUser> _userManager;


	public EmailService(IConfiguration config, UserManager<AppUser> userManager)
	{
		_config = config;
		_userManager = userManager;
	}

	public Task SendEmailAsync(string toEmail, string subject, string body, bool isBodyHTML)
	{
		try
		{
			string MailServer = _config["EmailSettings:MailServer"]!;
			string FromEmail = _config["EmailSettings:FromEmail"]!;
			string Password = _config["EmailSettings:Password"]!;
			int Port = int.Parse(_config["EmailSettings:MailPort"]!);
			var client = new SmtpClient(MailServer, Port)
			{
				Credentials = new NetworkCredential(FromEmail, Password),
				EnableSsl = true,
				
			};
			MailMessage mailMessage = new MailMessage(FromEmail, toEmail, subject, body)
			{
				IsBodyHtml = isBodyHTML
			};
			return client.SendMailAsync(mailMessage);
		}
		catch (Exception ex)
		{

			throw new Exception(ex.Message);
		}
	}

	public async Task SendEmailConfirm(AppUser user)
	{

		var token = await _userManager.GenerateEmailConfirmationTokenAsync(user!);
		var confirmationLink = _config["ActionUrls:ConfirmEmail"] + $"?userId={user!.Id}&token={token}";
		var title = "Confirm Your Email";
		var body = $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.";


		await SendEmailAsync(user.Email!, title, body, true);
	}

	public async Task SendResetPassword(AppUser user, string token)
	{

		var confirmationLink = _config["ActionUrls:ResetPassword"] + $"?userId={user!.Id}&token={token}";
		var title = "Reset passsword";
		var body = $@"For reset your password by <a href='{confirmationLink}'>clicking here</a>.";




		await SendEmailAsync(user.Email!, title, body, true);
	}
}

