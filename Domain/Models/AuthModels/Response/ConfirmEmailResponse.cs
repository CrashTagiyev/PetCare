using Domain.Models.AuthModels.ResponseAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.AuthModels.Response
{
	public class ConfirmEmailResponse : IResponse
	{
		public string StatusMessage { get; set; }=string.Empty;
		public HttpStatusCode StatusCode { get; set; }
	}
}
