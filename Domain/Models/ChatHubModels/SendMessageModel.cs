using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.ChatHubModels
{
	public record SendMessageModel(string username,string message, string groupName);
}
