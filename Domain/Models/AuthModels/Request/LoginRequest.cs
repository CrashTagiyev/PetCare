using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.AuthModels.Request
{
	public class LoginRequest
	{
		public string EmailAddress { get; set; }
		public string PasswordHash { get; set; }
	
	}
}
