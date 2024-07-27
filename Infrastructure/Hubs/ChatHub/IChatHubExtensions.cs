using Domain.Models.ChatHubModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Hubs.ChatHub
{
	public interface IChatHubExtensions
	{
		Task SendMessage( string username,string message, string groupName);
		Task GetConnectedChatsMessages(string groupName);
	}
}
