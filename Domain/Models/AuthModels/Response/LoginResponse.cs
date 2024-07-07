using Domain.Models.AuthModels.ResponseAbstract;
using System.Net;

namespace Domain.Models.AuthModels.Response
{
	public class LoginResponse : IResponse
	{
		public string? AccessToken { get; set; } = string.Empty;
		public string? RefreshToken { get; set; } = string.Empty;
		public string StatusMessage { get; set; } = string.Empty;
		public HttpStatusCode StatusCode { get; set; }
	}
}
