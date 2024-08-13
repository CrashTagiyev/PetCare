using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.AuthModels.Request
{
	public class LoginRequest
	{
		[EmailAddress]
		public string EmailAddress { get; set; }= string.Empty;
		public string Password { get; set; } = string.Empty;
	
	}
}
