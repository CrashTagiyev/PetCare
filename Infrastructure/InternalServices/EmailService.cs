using System.Net;
using System.Net.Mail;
using Application.ServiceAbstracts;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

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

	public async Task SendEmailConfirm(AppUser user)
	{
		var token = await _userManager.GenerateEmailConfirmationTokenAsync(user!);
		var confirmationLink = _config["ActionUrls:ConfirmEmail"] + $"?userId={user!.Id}&token={token}";
		var title = "Confirm Your Email";
		var body = $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.";


		await SendEmailAsync(user.Email!, title,body, true);
	}

	public async Task SendResetPassword(AppUser user,string token)
	{
	
		var confirmationLink = _config["ActionUrls:ResetPassword"] + $"?userId={user!.Id}&token={token}";
		var title = "Reset passsword";
		var body = $@"For reset your password by <a href='{confirmationLink}'>clicking here</a>.";




		await SendEmailAsync(user.Email!, title, body, true);
	}
}


    //<html>
    //    <body>
    //        <p>To reset your password, please click the link below and fill out the form:</p>
    //        <form id = 'resetForm' action='{confirmationLink}' method='get'>
    //            <input type = 'hidden' name='UserId' value='{user.Id}' />
    //            <input type = 'hidden' name='Token' value='{token}' />
    //            <label for='NewPassword'>New Password:</label>
    //            <input type = 'password' id='NewPassword' name='NewPassword' required />
    //            <br />
    //            <label for='ConfirmPassword'>Confirm Password:</label>
    //            <input type = 'password' id='ConfirmPassword' name='ConfirmPassword' required />
    //            <br />
    //            <input type = 'submit' value='Reset Password' />
    //        </form>
    //    </body>
    //</html>";