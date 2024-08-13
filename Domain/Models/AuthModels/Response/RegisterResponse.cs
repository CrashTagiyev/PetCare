using Domain.Models.AuthModels.ResponseAbstract;
using System.Net;

namespace Domain.Models.AuthModels.Response;

public class RegisterResponse:IResponse
{
    public string StatusMessage { get; set; } = string.Empty;
    public HttpStatusCode StatusCode { get; set; }
}