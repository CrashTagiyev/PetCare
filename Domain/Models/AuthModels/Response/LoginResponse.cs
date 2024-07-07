using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.AuthModels.Response
{
	public class LoginResponse
	{
		public string? AccessToken { get; set; } = string.Empty;
		public string? RefreshToken { get; set; } = string.Empty;
		public string StatusMessage { get; set; } = string.Empty;
		public HttpStatusCode? StatusCode { get; set; }
	}
}
