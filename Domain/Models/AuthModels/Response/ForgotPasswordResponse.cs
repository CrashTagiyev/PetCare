using Domain.Models.AuthModels.ResponseAbstract;
using System.Net;

namespace Domain.Models.AuthModels.Response
{
	public class ForgotPasswordResponse : IResponse
	{
		public string StatusMessage { get; set; } = string.Empty;
		public HttpStatusCode StatusCode { get; set; }
		public string Token { get; set; }=string.Empty;
		public int UserId { get; set; }
	}
}
