using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.AuthModels.ResponseAbstract
{
    public interface IResponse
    {
        string StatusMessage { get; set; }
        HttpStatusCode StatusCode { get; set;}
    }
}
